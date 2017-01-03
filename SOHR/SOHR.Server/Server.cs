using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOHR.Shared;
using SOHR.Shared.Contracts;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace SOHR.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Server : IClientService
    {
        #region FIELDS
        ObservableCollection<Header> setHeaders;
        ObservableCollection<File> setFiles;
        
        #endregion // FIELDS

        #region CONSTRUCTOR
        public Server()
        {
            setHeaders = new ObservableCollection<Header>();
            setFiles = new ObservableCollection<File>();
            Path = @"RuleSets";
            LoadFiles();
        }
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Pfad, wo der Server die Fragensätze abspeichert
        /// </summary>
        string Path { get; set; }
        /// <summary>
        /// Liste der geladenen Fragensätze
        /// </summary>
        internal ObservableCollection<Header> Headers
        { 
            get
            {
                return setHeaders;
            }
            set
            {
                setHeaders = value;
            }
        }
        /// <summary>
        /// Liste der geladenen Fragensätze
        /// </summary>
        internal ObservableCollection<File> Files
        {
            get
            {
                return setFiles;
            }
            set
            {
                setFiles = value;
            }
        }
        #endregion // PROPERTIES

        #region PRIVATE METHODS

        void LoadFiles()
        {
            Files.Clear();
            IEnumerable<string> files = Directory.GetFiles(Path).ToList();
            files = files.Where(f => f.Contains(".csv"));
            StreamReader streamReader;
            File fileNew;
            RuleSet setNew;
            Question questionNew;
            int numberOfQuestions;
            Answer answerNew;
            int numberOfAnswers;
            int points;
            Result resultNew;
            int numberOfResults;
            string[] line;

            foreach (var file in files)
            {
                streamReader = new StreamReader(file);
                fileNew = new File() { Path = file };
                setNew = new RuleSet();
                setNew.Questions = new ObservableCollection<Question>();
                setNew.PossibleResults = new ObservableCollection<Result>();
                streamReader.ReadLine(); // Achtung ...
                streamReader.ReadLine(); //...
                line = streamReader.ReadLine().Split(';'); //Name ...
                setNew.Name = line[1];
                line = streamReader.ReadLine().Split(';'); // ID ...
                setNew.ID = new Guid(line[1]);
                streamReader.ReadLine(); // Letzte Änderung ...
                line = streamReader.ReadLine().Split(';'); // Kommentar: ...
                setNew.Comment = line[1];
                line = streamReader.ReadLine().Split(';'); // Fragen: ...
                Int32.TryParse(line[1], out numberOfQuestions);
                line = streamReader.ReadLine().Split(';'); // Mögliche Ergebnisse
                Int32.TryParse(line[1], out numberOfResults);
                streamReader.ReadLine(); // Min: ...
                streamReader.ReadLine(); // Max: ...
                streamReader.ReadLine(); //
                streamReader.ReadLine(); // Fragen
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    line = streamReader.ReadLine().Split(';'); // Frage x, y Antwortmöglichkeiten
                    Int32.TryParse(line[2], out numberOfAnswers);
                    line = streamReader.ReadLine().Split(';');
                    questionNew = new Question();
                    questionNew.PossibleAnswers = new ObservableCollection<Answer>();
                    questionNew.ID = new Guid(line[1]);
                    questionNew.Name = streamReader.ReadLine();
                    for (int j = 0; j < numberOfAnswers; j++)
                    {
                        answerNew = new Answer();
                        line = streamReader.ReadLine().Split(';');
                        answerNew.Name = line[0];
                        Int32.TryParse(line[1], out points);
                        answerNew.Points = points;
                        questionNew.PossibleAnswers.Add(answerNew);
                    }
                    setNew.Questions.Add(questionNew);
                    streamReader.ReadLine();
                }
                
                for (int k = 0; k < numberOfResults; k++)
                {
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    resultNew = new Result();
                    resultNew.Name = streamReader.ReadLine();
                    line = streamReader.ReadLine().Split(';');
                    Int32.TryParse(line[1], out points);
                    resultNew.Min = points;
                    line = streamReader.ReadLine().Split(';');
                    Int32.TryParse(line[1], out points);
                    resultNew.Max = points;
                    setNew.PossibleResults.Add(resultNew);
                }
                fileNew.RuleSet = setNew;
                Files.Add(fileNew);
            }
        }

        public ObservableCollection<Header> LoadRuleSetHeaders()
        {
            Headers.Clear();
            foreach (var file in Files)
            {
                Headers.Add(new Header { Name = file.RuleSet.Name, ID = file.RuleSet.ID, Path = file.Path });
            }
            return Headers;
        }

        public RuleSet LoadRuleSet(Guid ID)
        {
            return Files.Where(f => f.RuleSet.ID == ID).First().RuleSet;
        }

        void IClientService.SaveRuleSet(RuleSet set)
        {
            //Überprüfen, nicht aktuell!!


            File file;
            // ID schon vorhanden?
            if (Files.Where(f => f.RuleSet.ID == set.ID).Count() > 0)
            {
                file = Files.Where(f => f.RuleSet.ID == set.ID).First();
            }
            else
            {
                file = new File() { RuleSet = set };
            }

            int countQuestion = 0; // Zähler für die Durchnummerierung der Fragen
            int countResult = 0; // Zähler für die Durchnummerierung der Ergebnisse

            file.StreamWriter = new StreamWriter(file.Path);
            file.StreamWriter.WriteLine("Achtung;Dies ist eine automatisch generierte Datei. Manuelle Änderungen können zu einem Fehlverhalten führen.");
            file.StreamWriter.WriteLine();
            file.StreamWriter.WriteLine("Name;{0}", file.RuleSet.Name);
            file.StreamWriter.WriteLine("ID;{0}", file.RuleSet.ID.ToString());
            file.StreamWriter.WriteLine("Letzte Änderung;{0}", DateTime.Now.ToString());
            file.StreamWriter.WriteLine("Kommentar;{0}", file.RuleSet.Comment);
            file.StreamWriter.WriteLine("Fragen;{0}", file.RuleSet.Questions.Count);
            file.StreamWriter.WriteLine("Mögliche Ergebnisse;{0}", file.RuleSet.PossibleResults.Count);
            file.StreamWriter.WriteLine("Min;{0}", file.RuleSet.PossibleMin);
            file.StreamWriter.WriteLine("Max;{0}", file.RuleSet.PossibleMax);
            file.StreamWriter.WriteLine();
            file.StreamWriter.WriteLine("Fragen");
            countQuestion = 0;
            foreach (var question in file.RuleSet.Questions)
            {
                file.StreamWriter.WriteLine("Frage {0};{1} Antwortmöglichkeiten", countQuestion, question.PossibleAnswers.Count);
                file.StreamWriter.WriteLine("ID;{0}", question.ID);
                file.StreamWriter.WriteLine(question.Name);
                foreach (var answer in question.PossibleAnswers)
                {
                    file.StreamWriter.WriteLine("{0};{1}", answer.Name, answer.Points);
                }
                file.StreamWriter.WriteLine();
                countQuestion++;
            }
            file.StreamWriter.WriteLine("Ergebnisse");
            foreach (var result in file.RuleSet.PossibleResults)
            {
                file.StreamWriter.WriteLine("Ergebnis;{0}", countResult);
                file.StreamWriter.WriteLine(result.Name);
                file.StreamWriter.WriteLine("Min;{0}", result.Min);
                file.StreamWriter.WriteLine("Max;{1}", result.Max);
                countResult++;
            }
        }

        public void DeleteRuleSet(Guid ID)
        {
            throw new NotImplementedException();
        }
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}

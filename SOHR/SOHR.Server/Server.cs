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
            int counter = 0;

            foreach (var file in files)
            {
                streamReader = new StreamReader(file);
                fileNew = new File() { Path = file };
                setNew = new RuleSet();
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
                Console.WriteLine("Regelsatz {0} geladen.", fileNew.RuleSet.Name);
                counter++;
            }
            Console.WriteLine("{0} Regelsätze geladen.", counter);
        }

        public ObservableCollection<Header> LoadRuleSetHeaders()
        {
            Headers.Clear();
            int counter = 1;
            foreach (var file in Files)
            {
                Headers.Add(new Header { Name = file.RuleSet.Name, ID = file.RuleSet.ID, Path = file.Path });
                counter++;
            }
            Console.WriteLine("{0} Header an Client übergeben.", counter);
            return Headers;
        }

        public RuleSet LoadRuleSet(Guid ID)
        {
            var set = Files.Where(f => f.RuleSet.ID == ID).First().RuleSet;
            Console.WriteLine("Satz {0} an Client übergeben.", set.Name);
            return set;
        }

        void IClientService.SaveRuleSet(RuleSet set)
        {
            File file;
            StreamWriter streamWriter;
            // ID schon vorhanden?
            if (Files.Where(f => f.RuleSet.ID == set.ID).Count() > 0)
            {
                file = Files.Where(f => f.RuleSet.ID == set.ID).First();
            }
            else
            {
                file = new File() { RuleSet = set };
                file.Path = String.Format(@"RuleSets\{0}.csv", set.Name);
            }

            int countQuestion = 1; // Zähler für die Durchnummerierung der Fragen
            int countResult = 1; // Zähler für die Durchnummerierung der Ergebnisse
            streamWriter = new StreamWriter(file.Path, false);

            streamWriter.WriteLine("Achtung;Dies ist eine automatisch generierte Datei. Manuelle Änderungen können zu einem Fehlverhalten führen.");
            streamWriter.WriteLine();
            streamWriter.WriteLine("Name;{0}", file.RuleSet.Name);
            streamWriter.WriteLine("ID;{0}", file.RuleSet.ID.ToString());
            streamWriter.WriteLine("Letzte Änderung;{0}", DateTime.Now.ToString());
            streamWriter.WriteLine("Kommentar;{0}", file.RuleSet.Comment);
            streamWriter.WriteLine("Fragen;{0}", file.RuleSet.Questions.Count);
            streamWriter.WriteLine("Mögliche Ergebnisse;{0}", file.RuleSet.PossibleResults.Count);
            streamWriter.WriteLine("Min;{0}", file.RuleSet.PossibleMin);
            streamWriter.WriteLine("Max;{0}", file.RuleSet.PossibleMax);
            streamWriter.WriteLine();
            streamWriter.WriteLine("Fragen");
            countQuestion = 1;
            foreach (var question in file.RuleSet.Questions)
            {
                streamWriter.WriteLine("Frage {0};Antwortmöglichkeiten;{1}", countQuestion, question.PossibleAnswers.Count);
                streamWriter.WriteLine("ID;{0}", question.ID);
                streamWriter.WriteLine(question.Name);
                foreach (var answer in question.PossibleAnswers)
                {
                    streamWriter.WriteLine("{0};{1}", answer.Name, answer.Points);
                }
                streamWriter.WriteLine();
                countQuestion++;
            }
            streamWriter.WriteLine("Ergebnisse");
            foreach (var result in file.RuleSet.PossibleResults)
            {
                streamWriter.WriteLine("Ergebnis;{0}", countResult);
                streamWriter.WriteLine(result.Name);
                streamWriter.WriteLine("Min;{0}", result.Min);
                streamWriter.WriteLine("Max;{0}", result.Max);
                streamWriter.WriteLine();
                countResult++;
            }
            streamWriter.Close();
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

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOHR.Shared;
using System.Collections.ObjectModel;

namespace SOHR.Server
{
    public class Server
    {
        #region FIELDS
        ObservableCollection<string> setRuleSetHeaders;
        ObservableCollection<File> setFiles;
        
        #endregion // FIELDS

        #region CONSTRUCTOR
        public Server(string path)
        {
            Path = path;
            setFiles = new ObservableCollection<File>();
            setFiles = new ObservableCollection<File>();
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
        internal ObservableCollection<string> RulesetHeaders
        {
            get
            {
                return setRuleSetHeaders;
            }
            set
            {
                setRuleSetHeaders = value;
            }
        }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        internal void InitServer()
        {
            IEnumerable<string> files = Directory.GetFiles(Path).ToList();
            files = files.Where(f => f.Contains(".csv"));
            foreach (var file in files)
            {
                Files.Add(new File(file));
                var test = DateTime.Now.ToString();
            }
        }
        /// <summary>
        /// Laden der Header und der ID
        /// </summary>
        internal void LoadFuleSetHeaders()
        {
            string[] line;
            foreach (var file in Files)
            {
                file.StreamReader = new StreamReader(file.FileName);
                file.StreamReader.ReadLine(); //Achtung: ...
                file.StreamReader.ReadLine(); //...
                line = file.StreamReader.ReadLine().Split(';'); //Name: ...
                file.RuleSet.Name = line[1];
                line = file.StreamReader.ReadLine().Split(';'); // ID: ...
                file.RuleSet.ID = new Guid(line[1]);

                file.StreamReader.Close();
            }
        }
        /// <summary>
        /// Laden der Rollensätze
        /// </summary>
        internal void LoadRuleSets()
        {
            int i = 0;     
            foreach (var file in Files)
            {
                file.StreamWriter = new StreamWriter(file.FileName);
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
                i = 0;
                foreach (var question in file.RuleSet.Questions)
                {



                    i++;
                }
            }

        }
        /// <summary>
        /// Speichern der Rollensätze
        /// </summary>
        internal void SaveRuleSets()
        {
            //TODO: Methode zum Speichern eines bestimmeten Satzes
        }
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}

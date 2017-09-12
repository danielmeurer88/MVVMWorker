using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WorkerList
{
    class WorkerModel
    {

        public ObservableCollection<Worker> Workers { get; set; }

        string _filename = "test.txt";

        public WorkerModel()
        {
            Workers = WorkerModel.Load(_filename);
        }

        /// <summary>
        /// Saves the ObservableCollection<Worker> to an xml file
        /// </summary>
        public void Save()
        {
            string path = Directory.GetCurrentDirectory() + "/" + _filename;

            using (var writer = new System.IO.StreamWriter(path))
            {
                var serializer = new XmlSerializer(Workers.GetType());
                serializer.Serialize(writer, Workers);
                writer.Flush();
            }
        }

        /// <summary>
        /// Load an object from an xml file
        /// </summary>
        /// <param name="filename">string of the file's name</param>
        /// <returns>ObservableCollection<Worker> created from the xml file</returns>
        public static ObservableCollection<Worker> Load(string filename)
        {

            string path = Directory.GetCurrentDirectory() + "/" + filename;

            using (var stream = System.IO.File.OpenRead(path))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Worker>));
                return serializer.Deserialize(stream) as ObservableCollection<Worker>;
            }
        }


    }
}

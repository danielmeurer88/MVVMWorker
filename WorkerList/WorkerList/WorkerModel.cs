using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkerList
{
    class WorkerModel
    {

        static ObservableCollection<Worker> _workers;

        public static ObservableCollection<Worker> GetWorker()
        {
            ObservableCollection<Worker> col = new ObservableCollection<Worker>();
            col.Add(new Worker() { Surename="Peter", Lastname="Bido", Age=28, YearsOfExperience=5, Degree=Degree.Bachelor } );
            col.Add(new Worker() { Surename = "Tuan", Lastname = "Kim", Age = 34, YearsOfExperience = 6, Degree = Degree.Doctorate });
            col.Add(new Worker() { Surename = "Jack", Lastname = "Donovan", Age = 38, YearsOfExperience = 12, Degree = Degree.Master });
            col.Add(new Worker() { Surename = "Fritz", Lastname = "Müller", Age = 55, YearsOfExperience = 38, Degree = Degree.None });
            _workers = col;
            return col;
        }

        /// <summary>
        /// Saves to an xml file
        /// </summary>
        /// <param name="FileName">File path of the new xml file</param>
        public void Save(string FileName)
        {
            string filename = Directory.GetCurrentDirectory() + "/" + FileName;

            using (var writer = new System.IO.StreamWriter(filename))
            {
                var serializer = new XmlSerializer(_workers.GetType());
                serializer.Serialize(writer, _workers);
                writer.Flush();
            }
        }

    }
}

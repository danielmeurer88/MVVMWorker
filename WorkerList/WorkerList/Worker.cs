using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerList
{
    public class Worker
    {
        string _surename;
        string _lastname;
        int _xyears;
        int _age;
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Surename
        {
            get { return _surename; }
            set { _surename = value; }
        }


        public int YearsOfExperience {
            get { return _xyears; }
            set { _xyears = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Degree Degree { get; set; }

        public static string GetDegreeString(Worker w)
        {
            return "Test";
        }

        public Worker()
        {
            
        }
    }

    public enum Degree {
        None, Bachelor, Master, Doctorate, NotFound
    }
}

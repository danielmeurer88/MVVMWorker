using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerList
{
    public class Worker
    {

        public string Lastname { get; set; }

        public string Surename { get; set; }


        public int YearsOfExperience { get; set; }

        public int Age { get; set; }

        public Degree Degree { get; set; }


        public Worker()
        {
            
        }
    }

    public enum Degree {
        None, Bachelor, Master, Doctorate, NotFound
    }
}

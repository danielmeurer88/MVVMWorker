using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerList
{
    public class WorkerViewModel
    {

        public ObservableCollection<Worker> Workers { get; set; }


        public WorkerViewModel()
        {
            Workers = WorkerModel.GetWorker();
        }

    }
}

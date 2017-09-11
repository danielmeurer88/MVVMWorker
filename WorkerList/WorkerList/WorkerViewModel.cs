using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WorkerList
{
    public class WorkerViewModel
    {

        public ObservableCollection<Worker> Workers { get; set; }


        public WorkerViewModel()
        {
            Workers = WorkerModel.GetWorker();
        }

        public void MarkupEx_AddNewWorker(object sender, EventArgs e)
        {
            AddNewWorkerWindow addNewWorkerWindow = new AddNewWorkerWindow();
            addNewWorkerWindow.Show();
        }

    }
}

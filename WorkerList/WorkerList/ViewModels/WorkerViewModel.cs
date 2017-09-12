using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WorkerList.ViewModels
{
    public class WorkerViewModel : WorkerViewModelBase
    {

        public ObservableCollection<Worker> Workers { get; private set; }

        public DelegateCommand DeleteCommand { get; private set; }

        WorkerModel _workerModel;

        AddNewWorkerWindow _addNewWorkerWindow = null;

        public WorkerViewModel()
        {
            _workerModel = new WorkerModel();
            Workers = _workerModel.Workers;

            DeleteCommand = new DelegateCommand(DeleteEntry,
                delegate (object parameter)
                {

                    if (parameter == null) return false;
                    
                    ListBox listBox = (ListBox)parameter;
                    if (listBox.SelectedIndex >= 0)
                        return true;
                    else
                        return false;
                }    
            );
            

        }

        public void DeleteEntry(object parameter)
        {
            ListBox listBox = (ListBox) parameter;
            if (listBox.SelectedItem != null)
            {
                //Worker selw = (Worker)listBox.SelectedItem;
                int index = listBox.SelectedIndex;
                Workers.RemoveAt(index);
            }
        }

        public void MarkupEx_OpenWindowAddNewWorker(object sender, EventArgs e)
        {

            if (_addNewWorkerWindow == null)
            {
                _addNewWorkerWindow = new AddNewWorkerWindow();
                AddWorkerViewModel childvm = (AddWorkerViewModel)_addNewWorkerWindow.DataContext;
                childvm.ParentViewModel = this;
                _addNewWorkerWindow.Show();
            }
            else
            {
                _addNewWorkerWindow.Focus();
            }
            
        }

        public void OnClosingWindowAddNewWorker()
        {
            _addNewWorkerWindow = null;
        }


        public void MarkupEx_Save(object sender, EventArgs e)
        {
            _workerModel.Save();
        }

    }

    public class WorkerViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            var handler = PropertyChanged;

            if (handler != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

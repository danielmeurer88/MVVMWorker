using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WorkerList.ViewModels
{
    public class AddWorkerViewModel : AddWorkerViewModelBase
    {


        public ObservableCollection<Worker> Workers { get; set; }

        public DelegateCommand AddWorkerCommand { get; private set; }

        public WorkerViewModel ParentViewModel;

        #region NewWorker Properties
        string _surename;
        string _lastname;
        string _xyears;
        string _age;
        Degree _newdegree = Degree.None;

        public string NewLastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("NewLastname");
            }
        }

        public string NewSurename
        {
            get { return _surename; }
            set { _surename = value; OnPropertyChanged("NewSurename"); }
        }


        public string NewYearsOfExperience
        {
            get { return _xyears; }
            set { _xyears = value; OnPropertyChanged("NewYearsOfExperience"); }
        }

        public string NewAge
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("NewAge"); }
        }

        #endregion

        public AddWorkerViewModel()
        {

            AddWorkerCommand = new DelegateCommand(AddWorker, CanExecuteAddWorker);
        }

        public void AddWorker(object parameter)
        {
            int age = int.Parse(NewAge);
            int ex = int.Parse(NewYearsOfExperience);
            string sure = NewSurename.ToString();
            string last = NewLastname.ToString();
            Degree d = _newdegree;

            Worker newWorker = new Worker() { Lastname = last, Surename = sure, Age = age, YearsOfExperience = ex, Degree = d };
            ParentViewModel.Workers.Add(newWorker);
            ParentViewModel.MarkupEx_Save(this, null);
            MarkupEx_Empty(null, null);
        }

        public bool CanExecuteAddWorker(object parameter)
        {
            if (parameter == null)
                return false;

            Grid grid = parameter as Grid;
            object child;
            TextBox t;
            int errors = 0;

            for (int i=0; i<grid.Children.Count; i++)
            {
                child = grid.Children[i];
                if(child.GetType() == typeof(TextBox))
                {
                    t = child as TextBox;
                    errors += 0;
                }
            }

            return (errors <= 0);
        }

        public void MarkupEx_OnClosingWindowAddNewWorker(object sender, EventArgs e)
        {
            var handler = ParentViewModel;
            if (handler != null)
            {
                ParentViewModel.OnClosingWindowAddNewWorker();
            }
        }

        public void MarkupEx_DegreeChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            int i = cb.SelectedIndex;

            _newdegree = (Degree)Degree.Parse(typeof(Degree), i.ToString());
        }

        public void MarkupEx_Empty(object sender, EventArgs e)
        {
            NewLastname = String.Empty;
            NewSurename = String.Empty;
            NewAge = String.Empty;
            NewYearsOfExperience = String.Empty;
        }

    }

    public class AddWorkerViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }

        }
    }
}

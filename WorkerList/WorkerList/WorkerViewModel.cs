﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WorkerList
{
    public class WorkerViewModel : WorkerViewModelBase
    {

        public ObservableCollection<Worker> Workers { get; set; }


        #region NewWorker Properties
        string _surename;
        string _lastname;
        string _xyears;
        string _age;
        Degree _newdegree = Degree.None;

        public string NewLastname
        {
            get { return _lastname; }
            set {
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

        public WorkerViewModel()
        {
            Workers = WorkerModel.GetWorker();
        }

        public void MarkupEx_OpenWindowAddNewWorker(object sender, EventArgs e)
        {
            AddNewWorkerWindow addNewWorkerWindow = new AddNewWorkerWindow();
            addNewWorkerWindow.Show();
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

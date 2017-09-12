using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WorkerList
{
    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute) : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;

            // important, or DeleteCommand won't test regularly if command can be executed
            // in case of buttons that would mean that .NET won't disable the button automatically
            if(canExecute != null)
                CommandManager.RequerySuggested += this.RaiseCanExecuteChanged;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}

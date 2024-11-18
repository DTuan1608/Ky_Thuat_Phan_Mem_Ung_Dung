using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KTPMUD.Models
{
    public class BaseModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class RelayCommand<T> : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public RelayCommand(Predicate<object> canExecute = null, Action<object> execute = null)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));


            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter) {
            try
            {
                return _canExecute == null ? true : _canExecute((T)parameter);
            }
            catch { return true; }
        }
        public void Execute(object parameter){
            _canExecute((T)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove {  CommandManager.RequerySuggested -= value;}
        }
    }
}

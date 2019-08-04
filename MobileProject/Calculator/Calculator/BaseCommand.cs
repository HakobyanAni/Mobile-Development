using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculator
{
    public class BaseCommand : ICommand
    {
        #region Fields
        private readonly Action<object> _execute;
        //private readonly Predicate<object> _canExecute;
        #endregion

        #region Constructors
        public BaseCommand(Action<object> execute)
        {
            _execute = execute;
        }

        //public BaseCommand(Action<object> execute, Predicate<object> canExecute)
        //{
        //    _execute = execute;
        //    _canExecute = canExecute;
        //}

        #endregion

        #region Methods
        //public void NotifyCanExecuteChanged()
        //{
        //    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //}
        #endregion

        #region ICommand Implementation
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
            //return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        #endregion
    }
}

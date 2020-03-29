using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Tutorial.Structure
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Fields

        #endregion

        #region Constructors
        public BaseViewModel()
        {
                
        }
        #endregion

        #region Commands
        public ICommand BackCommand { get; set; }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Methods
        protected virtual void BackExecute(object param)
        {

        }
        #endregion
    }
}
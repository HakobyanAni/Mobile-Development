using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        public event PropertyChangedEventHandler PropertyChanged;
        private string _text;
        #endregion

        #region
        public ViewModel()
        {
            CleanCommand = new Command(ClickClean);
            ClickCommand = new Command(ClickExecute);
            EqualCommand = new Command(ClickEqual);
        }
        #endregion

        #region Properties
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand CleanCommand { get; }
        public ICommand ClickCommand { get; }
        public ICommand EqualCommand { get; }
        #endregion

        #region Methods
        void ClickClean(object param)
        {
            Text = "";
        }

        void ClickExecute(object param)
        {
            if (param is string text)
            {
                Text += text;
            }
        }

        void ClickEqual(object param)
        {
            if (param is string text)
            {
                string[] elements = Text.Split('+', '-', 'x', '/', '%');
                foreach (string element in elements)
                {
                    var el = Convert.ToInt32(element);
                }

                Text = "00000000";
            }
        }
        #endregion
    }
}

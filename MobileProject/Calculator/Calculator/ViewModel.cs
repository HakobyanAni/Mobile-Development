using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _text;

        public ViewModel()
        {
            ClickCommand = new BaseCommand(ClickExecute);
        }

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

        public ICommand ClickCommand { get; }
        public ICommand EqualCommand { get; }
        void ClickExecute(object param)
        {
            if (param is string text)
            {
                Text += text;
            }
        }

        void ClickEqual(object param)
        {
            //if (param.ToString() == "=")
            //{
            Text = "00000000";
            // }     
        }
    }
}

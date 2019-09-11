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
        private int _result;
        #endregion

        #region Constructors
        public ViewModel()
        {
            CleanCommand = new Command(ClickClean);
            NumberCommand = new Command(ClickExecute);
            EqualCommand = new Command(ClickEqual);
            MinusCommand = new Command(ClickMinus);
            MultipleCommand = new Command(ClickMultiple);
            SumCommand = new Command(ClickSum);
            DivideCommand = new Command(ClickDivide);
            PercentCommand = new Command(ClickPercent);
            PointCommand = new Command(ClickPoint);
            SignCommand = new Command(ClickSign);
        }
        #endregion

        #region Properties
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }

        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand CleanCommand { get; }
        public ICommand NumberCommand { get; }
        public ICommand EqualCommand { get; }
        public ICommand MinusCommand { get; }
        public ICommand SumCommand { get; }
        public ICommand DivideCommand { get; }
        public ICommand MultipleCommand { get; }
        public ICommand PercentCommand { get; }
        public ICommand PointCommand { get; }
        public ICommand SignCommand { get; }
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

        void ClickMinus(object param)
        {

        }

        void ClickDivide(object param)
        {

        }

        void ClickSum(object param)
        {

        }

        void ClickMultiple(object param)
        {

        }

        void ClickPercent(object param)
        {

        }

        void ClickPoint(object param)
        {

        }

        void ClickSign(object param)
        {

        }
        #endregion
    }
}
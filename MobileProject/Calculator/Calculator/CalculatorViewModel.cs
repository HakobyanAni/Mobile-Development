using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Fields
        public event PropertyChangedEventHandler PropertyChanged;
        private string _text;
        private int _result;
        #endregion

        #region Constructors
        public CalculatorViewModel()
        {
            CleanCommand = new Command(ExecuteClean);
            NumberCommand = new Command(ExecuteNumberClick);
            EqualCommand = new Command(ExecuteEqual);
            MinusCommand = new Command(ExecuteMinus);
            MultipleCommand = new Command(ExecuteMultiple);
            SumCommand = new Command(ExecuteSum);
            DivideCommand = new Command(ExecuteDivide);
            PercentCommand = new Command(ExecutePercent);
            PointCommand = new Command(ExecutePoint);
            SignCommand = new Command(ExecuteSign);
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
        void ExecuteClean(object param)
        {
            Text = "";
        }

        void ExecuteNumberClick(object param)
        {
            if (param is string text)
            {
                Text += text;
            }
        }

        void ExecuteEqual(object param)
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

        void ExecuteMinus(object param)
        {

        }

        void ExecuteDivide(object param)
        {

        }

        void ExecuteSum(object param)
        {

        }

        void ExecuteMultiple(object param)
        {

        }

        void ExecutePercent(object param)
        {

        }

        void ExecutePoint(object param)
        {

        }

        void ExecuteSign(object param)
        {

        }
        #endregion
    }
}
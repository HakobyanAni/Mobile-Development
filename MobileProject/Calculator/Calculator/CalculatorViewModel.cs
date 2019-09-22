using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Fields
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstArgument = null;
        private string _secondArgument = null;
        private string _operation = null;
        private string _result;
        private bool isFirstArg = true;
        #endregion

        #region Constructors
        public CalculatorViewModel()
        {
            CleanCommand = new Command(ExecuteClean);
            NumberCommand = new Command(ExecuteNumberClick);
            EqualCommand = new Command(ExecuteEqual);
            PointCommand = new Command(ExecutePoint);
            SignCommand = new Command(ExecuteSign);
            OperationCommand = new Command(ExecuteOperation);
        }
        #endregion

        #region Properties
        public string FirstArgument
        {
            get
            {
                return _firstArgument;
            }
            set
            {
                if (_firstArgument != value)
                {
                    _firstArgument = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FirstArgument)));
                }
            }
        }

        public string SecondArgument
        {
            get
            {
                return _secondArgument;
            }
            set
            {
                if (_secondArgument != value)
                {
                    _secondArgument = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SecondArgument
)));
                }
            }
        }

        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                if (_operation != value)
                {
                    _operation = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Operation)));
                }
            }
        }

        public string Result
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Result)));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand CleanCommand { get; }
        public ICommand NumberCommand { get; }
        public ICommand OperationCommand { get; }
        public ICommand PointCommand { get; }
        public ICommand SignCommand { get; }
        public ICommand EqualCommand { get; }

        #endregion

        #region Methods
        void ExecuteClean(object param)
        {
            Result = "";
            FirstArgument = null;
            Operation = null;
            SecondArgument = null;
        }

        void ExecuteNumberClick(object param)
        {
            if (param is string text)
            {
                if (isFirstArg)
                {
                    FirstArgument += param;
                    Result += param;
                    isFirstArg = false;
                }
                else if (!isFirstArg)
                {
                    SecondArgument += param;
                    Result += param;
                    isFirstArg = true;
                }
            }
        }

        void ExecuteEqual(object param)
        {
            if (param is string text && FirstArgument != null && SecondArgument != null)
            {
                double firstArg = Convert.ToDouble(FirstArgument);
                double secondArg = Convert.ToDouble(SecondArgument);
                if (Operation == "+")
                {
                    Result = (firstArg + secondArg).ToString();
                }
                else if (Operation == "-")
                {
                    Result = (firstArg - secondArg).ToString();
                }
                else if (Operation == "*")
                {
                    Result = (firstArg * secondArg).ToString();
                }
                else if (Operation == "/")
                {
                    Result = (firstArg / secondArg).ToString();

                }
                else if (Operation == "%")
                {
                    Result = (firstArg % secondArg).ToString();
                }
                FirstArgument = null;
                Operation = null;
                SecondArgument = null;
            }
        }

        void ExecuteOperation(object param)
        {
            if (param is string text)
            {
                Operation = param.ToString();
                Result += Operation;
            }
        }

        void ExecutePoint(object param)
        {
        }

        void ExecuteSign(object param)
        {
            double firstArg = Convert.ToDouble(FirstArgument);
            double secondArg = Convert.ToDouble(SecondArgument);
            if (param.ToString() == "-")
            {
                if (isFirstArg)
                {
                    firstArg *= -1;
                }
                else
                {
                    secondArg *= -1;
                }
            }
        }
        #endregion
    }
}

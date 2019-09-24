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
        private bool IsMinus = false;
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SecondArgument)));
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
                }
                else if (!isFirstArg)
                {
                    SecondArgument += param;
                    Result += param;
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
                else if (Operation == "x")
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
                FirstArgument = Result;
                Operation = null;
                SecondArgument = null;
                isFirstArg = true;
            }
        }

        void ExecuteOperation(object param)
        {
            if (param is string text)
            {
                Operation = param.ToString();
                Result += Operation;
                isFirstArg = false;
            }
        }

        void ExecutePoint(object param)
        {
            if (isFirstArg)
            {
                FirstArgument += ".";
                Result += ".";
            }
            else if (!isFirstArg)
            {
                SecondArgument += ".";
                Result += ".";
            }
        }

        void ExecuteSign(object param)
        {
            IsMinus = !IsMinus;
            double firstArg = Convert.ToDouble(FirstArgument);
            double secondArg = Convert.ToDouble(SecondArgument);
            if (IsMinus)
            {
                if (isFirstArg)
                {
                    firstArg *= -1;
                    FirstArgument = firstArg.ToString();
                    Result = FirstArgument;
                }
                else
                {
                    SecondArgument = secondArg.ToString();
                    if (Operation == "-")
                    {
                        Result = FirstArgument + "+" + SecondArgument;
                        Operation = "+";
                    }
                    else
                    {
                        Result = FirstArgument + Operation + SecondArgument;
                    }
                }
            }
        }
        #endregion
    }
}
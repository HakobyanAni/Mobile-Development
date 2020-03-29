using Tutorial.Structure;
using System.Windows.Input;
using Xamarin.Forms;
using Tutorial.UI;

namespace Tutorial.ViewModels.User
{
    public class SignUpViewModel : BaseViewModel
    {
        #region Fields
        private string _name;
        private string _email;
        private string _password;
        private string _confirmPassword;
        #endregion

        #region Constructors
        public SignUpViewModel()
        {
            SignUpCommand = new Command(SignUpExecute);
            BackCommand = new Command(BackExecute);
        }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password != value)
                {
                    _password = value;
                }
            }
        }
        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                if (_confirmPassword != value)
                {
                    _confirmPassword = value;
                }
            }
        }
        #endregion

        #region Commands
        public ICommand SignUpCommand { get; set; }
        #endregion

        #region Executes
        private async void SignUpExecute(object param)
        {
            // write code calling back end to register user

            ConfirmCodePage confirmCodeView = new ConfirmCodePage();
            ConfirmCodeViewModel confirmCodeViewModel = new ConfirmCodeViewModel();
            confirmCodeView.BindingContext = confirmCodeViewModel;
            await App.Current.MainPage.Navigation.PushAsync(confirmCodeView);
        }

        protected override async void BackExecute(object param)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        #endregion
    }
}
using System.Windows.Input;
using Tutorial.Structure;
using Tutorial.UI;
using Xamarin.Forms;

namespace Tutorial.ViewModels.User
{
    public class LoginViewModel : BaseViewModel
    {
        #region Fields
        private string _email;
        private string _password;
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            LogInCommand = new Command(LogInExecute);
            SignUpPageCommand = new Command(SignUpPageExecute);
            ForgotPasswordPageCommand = new Command(ForgotPasswordPageExecute);
            BackCommand = new Command(BackExecute);
        }
        #endregion

        #region Properties
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
        #endregion

        #region Commands
        public ICommand LogInCommand { get; set; }
        public ICommand SignUpPageCommand { get; set; }
        public ICommand ForgotPasswordPageCommand { get; set; }
        #endregion

        #region Executes
        private void LogInExecute(object param)
        {
            // write code calling back end to log in user
            return;
        }

        private async void SignUpPageExecute (object param)
        {
            SignUpPage signUpView = new SignUpPage();
            SignUpViewModel signUpViewModel = new SignUpViewModel();
            signUpView.BindingContext = signUpViewModel;
            await App.Current.MainPage.Navigation.PushAsync(signUpView);
        }

        private async void ForgotPasswordPageExecute(object param)
        {
            ForgotPasswordPage forgotPasswordView = new ForgotPasswordPage();
            ForgotPasswordViewModel forgotPasswordViewModel = new ForgotPasswordViewModel();
            forgotPasswordView.BindingContext = forgotPasswordViewModel;
            await App.Current.MainPage.Navigation.PushAsync(forgotPasswordView);
        }

        protected override async void BackExecute(object param)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        #endregion
    }
}
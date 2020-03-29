using Tutorial.UI;
using Tutorial.ViewModels.User;
using Xamarin.Forms;
using System.Windows.Input;
using Tutorial.Structure;

namespace Tutorial
{
    public class MainPageViewModel : BaseViewModel 
    {
        public MainPageViewModel()
        {
            LogInPageCommand = new Command(LoginPageExecute);
            SignUpPageCommand = new Command(SignUpPageExecute);
        }

        #region Commands
        public ICommand LogInPageCommand { get; set; }
        public ICommand SignUpPageCommand { get; set; }
        #endregion

        private async void LoginPageExecute(object param)
        {
            LoginPage logInView = new LoginPage();
            LoginViewModel logInViewModel = new LoginViewModel();
            logInView.BindingContext = logInViewModel;
            await App.Current.MainPage.Navigation.PushAsync(logInView);
        }

        private async void SignUpPageExecute(object param)
        {
            SignUpPage signUpView = new SignUpPage();
            SignUpViewModel signUpViewModel = new SignUpViewModel();
            signUpView.BindingContext = signUpViewModel;
            await App.Current.MainPage.Navigation.PushAsync(signUpView);
        }
    }
}
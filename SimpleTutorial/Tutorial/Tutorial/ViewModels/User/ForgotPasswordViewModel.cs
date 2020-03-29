using Tutorial.Structure;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tutorial.ViewModels.User
{
    public class ForgotPasswordViewModel : BaseViewModel
    {
        #region Fields
        private string _email;
        private string _newPassword;
        private string _confirmPassword;
        #endregion

        #region Constructors
        public ForgotPasswordViewModel()
        {
            ForgotPasswordCommand = new Command(ForgotPasswordExecute);
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
        public string NewPassword
        {
            get
            {
                return _newPassword;
            }
            set
            {
                if (_newPassword != value)
                {
                    _newPassword = value;
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
        public ICommand ForgotPasswordCommand { get; set; }
        #endregion

        #region Executes
        public void ForgotPasswordExecute(object param)
        {
            // write code calling back end
            return;
        }

        protected override async void BackExecute(object param)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        #endregion
    }
}
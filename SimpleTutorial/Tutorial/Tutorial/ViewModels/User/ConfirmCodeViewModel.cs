using Tutorial.Structure;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tutorial.ViewModels.User
{
    public class ConfirmCodeViewModel : BaseViewModel
    {
        #region Fields
        private string _email;
        #endregion

        #region Constructors
        public ConfirmCodeViewModel()
        {
            ConfirmCodeCommand = new Command(ConfirmCodeExecute);
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
        #endregion

        #region Commands
        public ICommand ConfirmCodeCommand { get; set; }
        #endregion

        #region Executes
        private void ConfirmCodeExecute(object param)
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

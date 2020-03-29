using Tutorial.ViewModels.User;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            BindingContext = new ForgotPasswordViewModel();
        }
    }
}
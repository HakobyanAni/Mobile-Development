using Tutorial.ViewModels.User;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel();
        }
    }
}
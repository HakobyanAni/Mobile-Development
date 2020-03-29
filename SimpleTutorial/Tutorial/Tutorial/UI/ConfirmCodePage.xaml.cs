using Tutorial.ViewModels.User;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmCodePage : ContentPage
    {
        public ConfirmCodePage()
        {
            InitializeComponent();
            BindingContext = new ConfirmCodeViewModel();
        }
    }
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            MainPage mainPageView = new MainPage();
            MainPageViewModel mainPageViewModel = new MainPageViewModel();
            mainPageView.BindingContext = mainPageViewModel;
            Current.MainPage = new NavigationPage(mainPageView);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

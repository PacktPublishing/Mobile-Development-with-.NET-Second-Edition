using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAcross.Mobile.Client
{
    public partial class App : Application
    {
public App()
{
    InitializeComponent();
            //MainPage = new NavigationPage(new HomeView());
            //MainPage = new RootTabbedView();
    MainPage = new LoginView();
    //MainPage = new AppShell();
}

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using Microsoft.Identity.Client;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinB2C.Services;
using XamarinB2C.Views;

namespace XamarinB2C
{
    public partial class App : Application
    {
        public static IPublicClientApplication AuthenticationClient { get; private set; }
        public static object UIParent { get; set; } = null;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            
            AuthenticationClient = PublicClientApplicationBuilder.Create(Constants.ClientId)
               .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
               .WithB2CAuthority(Constants.AuthoritySignin)
               .WithRedirectUri($"msal{Constants.ClientId}://auth")
               .Build();

            MainPage = new NavigationPage(new LoginPage());
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

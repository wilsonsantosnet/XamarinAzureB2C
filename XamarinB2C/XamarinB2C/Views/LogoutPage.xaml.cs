﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinB2C.ViewModels;


namespace XamarinB2C.Views
{
    public partial class LogoutPage : ContentPage
    {
        AuthenticationResult authenticationResult;

        public LogoutPage(AuthenticationResult result)
        {
            InitializeComponent();
            authenticationResult = result;
        }

        protected override void OnAppearing()
        {
            if (authenticationResult != null)
            {
                if (authenticationResult.Account.Username != "unknown")
                {
                    messageLabel.Text = string.Format("Welcome {0}", authenticationResult.Account.Username);
                }
                else
                {
                    messageLabel.Text = string.Format("UserId: {0}", authenticationResult.Account.Username);
                }
            }

            base.OnAppearing();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();

            while (accounts.Any())
            {
                await App.AuthenticationClient.RemoveAsync(accounts.First());
                accounts = await App.AuthenticationClient.GetAccountsAsync();
            }

            await Navigation.PopAsync();
        }
    }
}
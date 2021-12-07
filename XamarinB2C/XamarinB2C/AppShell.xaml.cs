using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinB2C.ViewModels;
using XamarinB2C.Views;

namespace XamarinB2C
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

using AppCenterDemo_XamarinForms.ViewModels;
using AppCenterDemo_XamarinForms.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppCenterDemo_XamarinForms
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

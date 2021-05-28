using AppCenterDemo_XamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppCenterDemo_XamarinForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
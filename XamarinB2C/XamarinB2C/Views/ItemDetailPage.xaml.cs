using System.ComponentModel;
using Xamarin.Forms;
using XamarinB2C.ViewModels;

namespace XamarinB2C.Views
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
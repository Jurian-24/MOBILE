using System.ComponentModel;
using Xamarin.Forms;
using Mobile_1.ViewModels;

namespace Mobile_1.Views
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
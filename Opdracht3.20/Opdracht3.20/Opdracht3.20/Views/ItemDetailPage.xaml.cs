using System.ComponentModel;
using Xamarin.Forms;
using Opdracht3._20.ViewModels;

namespace Opdracht3._20.Views
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
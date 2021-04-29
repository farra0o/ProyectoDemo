using Laboratorio03.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Laboratorio03.Views
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
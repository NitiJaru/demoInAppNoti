using demoInAppNoti.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace demoInAppNoti.Views
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
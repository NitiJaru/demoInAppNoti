using Rg.Plugins.Popup.Pages;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoInAppNoti.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InAppNotiDialog : PopupPage
    {
        public InAppNotiDialog(string iconUrl, string title, string message)
        {
            InitializeComponent();

            InAppIcon.Source = Device.RuntimePlatform == Device.Android
                ? ImageSource.FromFile(iconUrl)
                : ImageSource.FromFile($"Images/{iconUrl}");
            InAppTitle.Text = title;
            InAppMsg.Text = message;
        }
    }
}
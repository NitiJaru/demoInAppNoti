using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Timers;
using demoInAppNoti.Views;
using System.Collections;

namespace demoInAppNoti.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private int counter = 1;
        private Timer timer;

        public Command ShowInAppNoti => new Command(async () =>
        {
            await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(
                new InAppNotiDialog("icon.png", $"เติมเงินเสร็จสิ้น ({counter++})", "คุณได้เติมเงินเข้ากระเป๋า ManaWallet เป็นจำนวน 50.00 THB")
                {
                    BackgroundColor = Color.Transparent,
                    Padding = new Thickness(0, 60, 0, 0),
                    InputTransparent = true,
                    IsEnabled = true,
                    CloseWhenBackgroundIsClicked = false,
                });
            timer.Start();
        });

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            timer = new Timer(3000);
            timer.Elapsed += async (sender, e) =>
            {
                timer.Stop();
                if (Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopupStack.Count > 0)
                {
                    await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAllAsync();
                }
            };
        }

        public ICommand OpenWebCommand { get; }
    }
}
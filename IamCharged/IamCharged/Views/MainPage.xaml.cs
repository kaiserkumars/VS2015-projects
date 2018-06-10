using System;
using IamCharged.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Windows.UI.Core;
using System.Threading.Tasks;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace IamCharged.Views
{
    public sealed partial class MainPage : Page
    {
        public string DeviceModel { get; }
        public string DeviceManufacturer { get; }
        public MainPage()
        {
            InitializeComponent();
            EasClientDeviceInformation eas = new EasClientDeviceInformation();
            DeviceManufacturer = eas.SystemManufacturer;
            DeviceModel = eas.SystemProductName;
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            this.CurrentDevices.Text = DeviceManufacturer+" "+DeviceModel;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Windows.Devices.Power.Battery.AggregateBattery.ReportUpdated += AggregateBatteryOnReportUpdated;

            await UpdatePercentage(Windows.Devices.Power.Battery.AggregateBattery);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            Windows.Devices.Power.Battery.AggregateBattery.ReportUpdated -= AggregateBatteryOnReportUpdated;
        }

        private async void AggregateBatteryOnReportUpdated(Windows.Devices.Power.Battery sender, object args)
        {
            await UpdatePercentage(sender);
        }

        private async Task UpdatePercentage(Windows.Devices.Power.Battery sender)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var batteryReport = sender.GetReport();
                var percentage = (batteryReport.RemainingCapacityInMilliwattHours.Value /
                                  (double)batteryReport.FullChargeCapacityInMilliwattHours.Value);
                this.BatteryPercentageTextBlock.Text = percentage.ToString("##%");
            });
        }
    }
}

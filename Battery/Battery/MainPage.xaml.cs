using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Power;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Battery
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage() { this.InitializeComponent(); }



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
                this.PercentBlock.Text = percentage.ToString("##%");
            });
        }

    }
}


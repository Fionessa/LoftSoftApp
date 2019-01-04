using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace LoftSoftApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Über Loftsoft";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://loftsoft.ch")));
            //BatteryTestCommand = new Command(() => this.BatteryTest());
        }

        public ICommand OpenWebCommand { get; }


        //private ICommand _batteryTestCommand;

        //public ICommand BatteryTestCommand {
        //    get
        //    {
        //        if (_batteryTestCommand == null)
        //        {
        //            _batteryTestCommand = new RelayCommand(
        //                param => this.BatteryTest()
        //            );
        //        }
        //        return _saveCommand;
        //    }
        //}
        

        public void BatteryTest()
        {
            var level = Battery.ChargeLevel; // returns 0.0 to 1.0 or 1.0 when on AC or no battery.

            var state = Battery.State;

            switch (state)
            {
                case BatteryState.Charging:
                    // Currently charging
                    break;
                case BatteryState.Full:
                    // Battery is full
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    // Currently discharging battery or not being charged
                    break;
                case BatteryState.NotPresent:
                // Battery doesn't exist in device (desktop computer)
                case BatteryState.Unknown:
                    // Unable to detect battery state
                    break;
            }

            var source = Battery.PowerSource;

            switch (source)
            {
                case BatteryPowerSource.Battery:
                    // Being powered by the battery
                    break;
                case BatteryPowerSource.AC:
                    // Being powered by A/C unit
                    break;
                case BatteryPowerSource.Usb:
                    // Being powered by USB cable
                    break;
                case BatteryPowerSource.Wireless:
                    // Powered via wireless charging
                    break;
                case BatteryPowerSource.Unknown:
                    // Unable to detect power source
                    break;
            }


        }


    }
}
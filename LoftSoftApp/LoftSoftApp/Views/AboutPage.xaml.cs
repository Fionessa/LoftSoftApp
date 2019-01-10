using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LoftSoftApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

        private void CheckBattery_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "You clicked me!";

            BatteryTest();
        }

        private void CheckBattery_Pressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just pressed!";
        }

        private void CheckLamp_Pressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just pressed!";
        }

        private void CheckLamp_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "You clicked me!";

            LampOut();
        }
        

        public async void BatteryTest()
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

            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;

            // Manufacturer (Samsung)
            var manufacturer = DeviceInfo.Manufacturer;

            // Device Name (Motz's iPhone)
            var deviceName = DeviceInfo.Name;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;

            this.lblBattery.Text = state.ToString();
            this.lblDeviceInfo.Text = manufacturer;


            // 47.4771515,8.3094978
            // 47.4766279, 8.3089182

            //var location = new Location(47.4766279, 8.3089182);
            //var options = new MapLaunchOptions { Name = "Bahnhofstrasse 31, 5400 Baden" };

            //await Map.OpenAsync(location, options);

            try
            {
                // Turn On
                await Flashlight.TurnOnAsync();

                Vibration.Vibrate();

                // Or use specified time
                var duration = TimeSpan.FromSeconds(2);
                Vibration.Vibrate(duration);

                // Turn Off
                // await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                fnsEx.ToString();
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                pEx.ToString();
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
                ex.ToString();
            }

        }

        public async void LampOut()
        {

            try
            {
                // Turn Off
                await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                fnsEx.ToString();
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                pEx.ToString();
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
                ex.ToString();
            }

        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

    }
}
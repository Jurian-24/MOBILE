using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;




namespace Opdracht5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;


            if (Accelerometer.IsMonitoring)
                Accelerometer.Stop();
            else
                Accelerometer.Start(SensorSpeed.UI);
            
        }
        int counter = 0;

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            if(counter == 1)
            {
                LampAan();
                counter = 0;
            }
            else
            {
                LampUit();
                counter++;
            }
        }

        void LampAan_Clicked(object sender, System.EventArgs e)
        {
            LampAan();
        }

        void LampUit_Clicked(object sender, System.EventArgs e)
        {
            LampUit();
        }

        async void LampAan()
        {
            try
            {
                await Flashlight.TurnOnAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                mijnLabel.Text = fnsEx.Message;
            }
            catch (PermissionException pEx)
            {
                mijnLabel.Text = pEx.Message;
            }
            catch (Exception ex)
            {
                mijnLabel.Text = ex.Message;
            }
        }
        async void LampUit()
        {
            try
            {
                await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                mijnLabel.Text = fnsEx.Message;
            }
            catch (PermissionException pEx)
            {
                mijnLabel.Text = pEx.Message;
            }
            catch (Exception ex)
            {
                mijnLabel.Text = ex.Message;
            }

        }

    }
}

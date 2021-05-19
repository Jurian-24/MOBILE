using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eerste_app
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string naam = mijnInput.Text;
            mijnLabel.Text = "Hallo " + naam;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            Getal2 = int.Parse(mijnInput.Text);
            double getal = Vermenigvuldiger.Value;
            mijnLabel.Text = "Antwoord = " + naam * getal;
        }
    }
}

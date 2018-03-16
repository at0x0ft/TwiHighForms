using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TwiHigh;

namespace TwiHigh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void FileIOBtn_Clicked(object sender, EventArgs args)
        {
            var data = await JsonIO.JsonReadAsync("TwiHigh.Settings.AppsSettings.json");
            this.label1.Text = data.CallbackURL;
        }
    }
}

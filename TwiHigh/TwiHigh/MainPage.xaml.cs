using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwiHigh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            this.ScreenNameLabel.Text = await OAuth.ShowLoginUserNameAsync();
        }
    }
}

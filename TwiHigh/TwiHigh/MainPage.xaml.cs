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

        private void FileIOBtn_Clicked(object sender, EventArgs args)
        {
            this.label1.Text = "FileIO test!";
        }
    }
}

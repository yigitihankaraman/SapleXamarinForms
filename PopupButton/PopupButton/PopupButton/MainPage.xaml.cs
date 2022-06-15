using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupButton
{
    public partial class MainPage : ContentPage
    {
        bool but = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            if (but)
            {   extButton.IsVisible = false; 
                but = false;
            }
            else
            {   extButton.IsVisible = true;
                but = true;
            }
            
        }
    }
}

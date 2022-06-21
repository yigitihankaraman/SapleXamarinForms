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
        bool ok = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            ImageButton obj = (ImageButton)sender;
            if (but)
            {
                await extButton.FadeTo(0, 1000, Easing.SinInOut);
                extButton.IsVisible = false;
                TranslateToBtn(obj);
                but = false;
            }
            else
            {
                TranslateToBtn(obj);
                await Task.Delay(500);
                extButton.IsVisible = true;
                await Task.Delay(500);
                await extButton.FadeTo(1, 1000, Easing.SinInOut);
                but = true;
            }
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            ImageButton obj = (ImageButton)sender;
            if (ok)
            {
                obj.Source = "Btn3_30.png";
                ok = false;
            }
            else
            {
                obj.Source = "Btn1_30.png";
                ok = true;
            }

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            ImageButton obj = (ImageButton)sender;

            TranslateToBtn(obj);
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            ImageButton obj = (ImageButton)sender;

            await obj.RotateTo(180);
            await obj.RotateTo(0, 500, Easing.SpringOut);
        }

        private async void TranslateToBtn(ImageButton imgbtn)
        {
            await imgbtn.TranslateTo(0, -5, 10);
            await imgbtn.TranslateTo(0, 0);
            await imgbtn.TranslateTo(0, 5, 10);
            await imgbtn.TranslateTo(0, 0);
        }
    }
}

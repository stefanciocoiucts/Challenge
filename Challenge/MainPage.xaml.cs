using System;
using Xamarin.Forms;

namespace Challenge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnPopup(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Added!", "OK");
        }
    }
}
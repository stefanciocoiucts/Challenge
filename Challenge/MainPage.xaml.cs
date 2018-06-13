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
        public void OnPopup(object sender, EventArgs e)
        {
            AddButton.Text = "Added";
        }

    }
}
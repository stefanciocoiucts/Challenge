using System;
using Xamarin.Forms;

namespace Challenge
{
    public partial class AddSong : ContentPage
    {
        public AddSong()
        {
            InitializeComponent();
        }
        public void OnPopup(object sender, EventArgs e)
        {
            AddButton.Text = "Added";
        }

    }
}

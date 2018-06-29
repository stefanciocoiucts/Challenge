using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void AddSongPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSong());
        }
    }

}
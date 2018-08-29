using System;
using Xamarin.Forms;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge
{
    public partial class AddSong : ContentPage
    {
        [Table("Tracks")] //Sq Brackets define a name for the tables used by SQL
        public class Track
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }
            [MaxLength(8)]
            public string Artist { get; set; }
            public string Genre { get; set; }
            public string TrackName { get; set; }
            public string TrackLength { get; set; }

        }

        public AddSong()
        {
            InitializeComponent();
        }

        public void OnPopup(object sender, EventArgs e)
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "Tracks.db3");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<Track>();
            if (db.Table<Track>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newTrack = new Track();
                newTrack.Artist = artistText.Text;
                newTrack.TrackName = trackText.Text;
                newTrack.TrackLength = tracklengthText.Text;
                newTrack.Genre = genreText.Text;
                db.Insert(newTrack);

            }

            Console.WriteLine("Reading data");
            var table = db.Table<Track>();
            foreach (var s in table)
            {
                Console.WriteLine(s.Id + " " + s.Artist);

                AddButton.Text = "Added";

                Console.WriteLine(artistText.Text);
                Console.WriteLine(trackText.Text);
                Console.WriteLine(genreText.Text);
                Console.WriteLine(tracklengthText.Text);
            }
        }
    }
}
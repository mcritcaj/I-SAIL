using Plugin.SimpleAudioPlayer;
using SQLite;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_Sail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RacePage : ContentPage
    {
        SQLiteConnection conn;
        public RacePage()
        {
            InitializeComponent();
            string libFolder = FileSystem.AppDataDirectory;
            string fname = System.IO.Path.Combine(libFolder, "Personnel.db");
            conn = new SQLiteConnection(fname);
            conn.CreateTable<Race>();
            lvRaces.ItemsSource = conn.Table<Race>().ToList();
        }

        private void Button_Clicked_AddRace(object sender, EventArgs e){
            Race newRace = new Race { RaceName = RaceName.Text };
            conn.Insert(newRace);
            lvRaces.ItemsSource = conn.Table<Race>().ToList();
        }


    }
}
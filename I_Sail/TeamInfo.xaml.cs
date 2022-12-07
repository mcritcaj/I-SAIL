using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_Sail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamInfo : ContentPage
    {
        SQLiteConnection conn;
        public TeamInfo()
        {
            InitializeComponent();
            string libFolder = FileSystem.AppDataDirectory;
            string fname = System.IO.Path.Combine(libFolder, "Personnel.db");
            conn = new SQLiteConnection(fname);
            conn.CreateTable<Team>();
            lvTeam.ItemsSource = conn.Table<Team>().ToList();
        }

        private void Button_Clicked_AddTeam(object sender, EventArgs e)
        {
            Team newTeam = new Team { TeamName = TeamName.Text };
            conn.Insert(newTeam);
            lvTeam.ItemsSource = conn.Table<Team>().ToList();
        }
    }
}
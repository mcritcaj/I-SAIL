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
    public partial class SailorInfo : ContentPage
    {
        SQLiteConnection conn;
        public SailorInfo()
        {
            InitializeComponent();
            string libFolder = FileSystem.AppDataDirectory;
            string fname = System.IO.Path.Combine(libFolder, "Personnel.db");
            conn = new SQLiteConnection(fname);
            conn.CreateTable<Sailor>();
            lvSailors.ItemsSource = conn.Table<Sailor>().ToList();
        }

        private void Button_Clicked(object sender, EventArgs e){
            Sailor newSailor = new Sailor { Name = SailorName.Text,School= SailorSchool.Text, Age= Int32.Parse(SailorAge.Text), Position=SailorPosition.Text };
            conn.Insert(newSailor);
            lvSailors.ItemsSource = conn.Table<Sailor>().ToList();
        }

        private void Button_Clicked_1(object sender, EventArgs e){
            lvSailors.ItemsSource = conn.Table<Sailor>().AsEnumerable().Where(s => s.School == SailorSearch.Text);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            lvSailors.ItemsSource = conn.Table<Sailor>().ToList();
        }
    }
}
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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            if (!Preferences.ContainsKey("userName")) Preferences.Set("userName", "Your Name Here");
            userNameLabel.Text = Preferences.Get("userName", "Your Name Hear");

            if (!Preferences.ContainsKey("userPassword")) Preferences.Set("userPassword", "********");
            userPasswordLabel.Text = Preferences.Get("userPassword", "********");

            if (!Preferences.ContainsKey("userSchool")) Preferences.Set("userSchool", "Your School Here");
            userSchoolLabel.Text = Preferences.Get("userSchool", "Your School Here");

        }

        private void Button_Clicked_Name(object sender, EventArgs e)
        {
            Preferences.Set("userName", userName.Text);
            userNameLabel.Text = Preferences.Get("userName", "Your Name Hear");
        }

        private void Button_Clicked_Password(object sender, EventArgs e)
        {
            Preferences.Set("userPassword", userPassword.Text);
            userPasswordLabel.Text = Preferences.Get("userPassword", "********");
        }

        private void Button_Clicked_School(object sender, EventArgs e)
        {
            Preferences.Set("userSchool", userSchool.Text);
            userSchoolLabel.Text = Preferences.Get("userSchool", "Your School Here");
        }
    }
}
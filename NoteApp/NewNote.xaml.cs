using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewNote : ContentPage
    {
        public NewNote()
        {
            InitializeComponent();
        }

        async private void Clicked_Save(object sender, EventArgs e)
        {

            Note note = new Note()
            {
                Name =  " -  " + nameEntry.Text,
                Importance = Convert.ToString(++importanceEntry.SelectedIndex)
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Note>();
                var numbreofRows = conn.Insert(note);

                if (numbreofRows > 0)
                    await DisplayAlert("Success", "Note Saved", "Great");
                else
                    await DisplayAlert("failure", "Note Not Saved", "Fuk");

                await Navigation.PopAsync();

                //Only one instance of the connection class can be active at a time
            }


        }

        /*private void Clicked_Bell(object sender, EventArgs e)
        {

        }*/
    }
}
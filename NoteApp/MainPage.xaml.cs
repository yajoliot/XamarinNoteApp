using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing() //Called everytime the MainPage is Displayed
        {
            base.OnAppearing();
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Note>();
                var notes = conn.Table<Note>();
                noteList.ItemsSource = notes;
            }
        }

        private void Clicked_3dots(object sender, EventArgs e)
        {

        }

        private void Clicked_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewNote());
        }

        private void Clicked_Delete(object sender, EventArgs e)
        {
            /*
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {

                Note n = (from nt in conn.Table<Note>()
                          where nt.Id ==
                          select nt).FirstOrDefault();

                if (n != null)
                    conn.Delete(n);

            }

            */
        }

        /*private void Double_Tapped(object sender, EventArgs e)
        {
           

             using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
             {

                 Note n = (from nt in conn.Table<Note>()
                           where nt.Id == theNote.Id
                           select nt).FirstOrDefault();

                 if (n != null)
                     conn.Delete(n);

             }

        }*/

        

        
    }
}

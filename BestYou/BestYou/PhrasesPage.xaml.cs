using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BestYou
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhrasesPage : ContentPage
    {
        public PhrasesPage()
        {
            InitializeComponent();
            RandomPhrase();
        }

        void buttonRandom_Clicked(System.Object sender, System.EventArgs e)
        {
            RandomPhrase();
        }

        void RandomPhrase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Phrases>();
                var vQuery = connection.Query<Phrases>("SELECT * FROM Phrases ORDER BY RANDOM()");
                List<Phrases> lvPhrases = new List<Phrases>();
                lvPhrases = vQuery.ToList<Phrases>();
                Phrases phrase = lvPhrases[0];
                labelPhrase.Text = phrase.Phrase;

                //List<Phrases> test = connection.Table<Phrases>().ToList();
                //labelPhrase.Text = test[0].Phrase;
            }
        }

        void buttonAll_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
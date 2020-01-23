using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace BestYou
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopulatePhrases();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Phrases>();
                //conn.Table<Phrases>();
                var phrases = conn.Query<Phrases>("Select * FROM Phrases").ToList();
                int iCount = phrases.Count;
                if(iCount > 0)
                {
                    //we're in here
                }
                else
                {
                    //we're in here.
                }
            }
        }


        private void PopulatePhrases()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                Phrases phrase = new Phrases() { Phrase = "I approve of myself." };
                connection.CreateTable<Phrases>();
                int rows = connection.Insert(phrase);
                if(rows > 0)
                {
                    //this was inserted successfully
                } else
                {
                    //this failed at some point
                }
            }
            //Database.PushPhrase("I approve of myself.");
            Database.PushPhrase("I love myself deeply and fully.");
            Database.PushPhrase("I am enough.");
            Database.PushPhrase("I am worth of love and joy.");
            Database.PushPhrase("My life is a gift.");
            Database.PushPhrase("Today, I choose me.");
            Database.PushPhrase("I am worthy of infinite compassion.");
            Database.PushPhrase("I am at peace with all that has happened in my life.");
            Database.PushPhrase("My life is filled with joy and abundance.");
            Database.PushPhrase("Happiness flows from me.");
            Database.PushPhrase("I will surround myself with positive people who will help bring the best out in me.");
            Database.PushPhrase("I am willing to keep going, when things get tough, to achieve the success I deserve.");
            Database.PushPhrase("My body is beautiful and expresses my spirit.");
            Database.PushPhrase("Today, I choose me.");
            Database.PushPhrase("I am grounded, peaceful, and centered.");
            Database.PushPhrase("I respect my limitations and thank myself for the things I am able to accomplish.");
            Database.PushPhrase("My life is full of happiness and love.");
            Database.PushPhrase("I feel pride in myself.");
            Database.PushPhrase("I am not the sum of my mistakes.");
            Database.PushPhrase("I feel beautiful, I am beautiful");
            Database.PushPhrase("I have everything I need.");
            Database.PushPhrase("I am blessed!");
            Database.PushPhrase("I find joy and pleasure in the most simple things in life.");
            Database.PushPhrase("I am competent, smart and able.");
            Database.PushPhrase("My opinions are valid and well-reasoned.");
            Database.PushPhrase("I am growing and changing for the better.");
            Database.PushPhrase("I believe in myself, my skills, and abilities.");
            Database.PushPhrase("I will let go of negativity about myself.");
            Database.PushPhrase("I see the best in other people.");
            Database.PushPhrase("My body is sacred and I will take care of it.");
            Database.PushPhrase("I recognise my good qualities, and there are many.");
            Database.PushPhrase("I am worthy of my successes.");
            Database.PushPhrase("I am confident with my plan for my life.");
            Database.PushPhrase("I love what I do and do what I am good at.");
            Database.PushPhrase("All of my actions lead to success.");
            Database.PushPhrase("I have a beautiful smiles.");
            Database.PushPhrase("A river of compassion washes away my anger and replaces it with love");
            Database.PushPhrase("I am worthy of being loved.");
            Database.PushPhrase("I am my own superhero.");
            Database.PushPhrase("I will not compare myself to others.");
            Database.PushPhrase("I don't sweat the small stuff.");
        }

        private void buttonContinue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}

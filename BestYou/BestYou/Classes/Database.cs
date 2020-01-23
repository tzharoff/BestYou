using System;
using Plugin.LocalNotifications;
using SQLite;

namespace BestYou
{
    //Phrase table
    //ID - keep track of phrase ID
    //Phrase - we're limiting phrases to 255 characters
    public class Phrases
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(255)]
        public string Phrase { get; set; }

        public Phrases()
        {
        }
    }

    //stats table
    //ID - this will be for the UserID
    //WeekID, we'll use this to keep track of phrases used per week
    //PhraseCount will be for the user to keep track of overall phrases used
    public class Stats
    {
        [PrimaryKey]
        public int ID { get; set; }

        [PrimaryKey]
        public int WeekID { get; set; }

        public int PhraseCount { get; set; }

        public Stats()
        {

        }
    }

    //I don't know if I'll do this for the school project, but I want to build this for the future
    //this app will go beyond school. we need more positivity in the world
    //Favorite Phrases table - this is an intersection table to keep track of favorite phrases
    //userID - from the stats table
    //phraseID from the phrases table
    public class FavoritePhrases
    {
        [PrimaryKey]
        public int UserID { get; set; }

        [PrimaryKey]
        public int PhraseID { get; set; }

        public FavoritePhrases()
        {

        }
    }

    public class Notifications
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [PrimaryKey]
        public int PhraseID { get; set; }

        public DateTime TimeToShow { get; set; }

        public Notifications()
        {

        }
    }

    //this will be used by stats
    //we want to keep track of how many phrases are used in a week
    //ID - this ID will be for the week in question
    //M-Su - used to keep track of phrases used per day
    public class WeekCount
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int MondayCount { get; set; }
        public int TuesdayCount { get; set; }
        public int WednesdayCount { get; set; }
        public int ThursdayCount { get; set; }
        public int FridayCount { get; set; }
        public int SaturdayCount { get; set; }
        public int SundayCount { get; set; }

        public WeekCount()
        {

        }
    }

    public class Database
    {
        public static void PushPhrase(string sPhrase)
        {
            Phrases phrase = new Phrases()
            {
                Phrase = sPhrase
            };
            PhraseInsert(phrase);
        }

        public static bool PhraseInsert(Phrases phrase)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Phrases>();
                int rows = connection.Insert(phrase);

                //phrase successfully added
                if (rows > 0)
                    return true;

                //phrase not successfully added
                return false;
            }
        }

        public static bool PhraseDelete(Phrases phrase)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                int _id = phrase.ID;
                connection.CreateTable<Phrases>();
                int rows = connection.Delete(phrase);

                //term successfully removed
                if (rows > 0)
                {
                    return true;
                }

                //term not successfully removed
                return false;
            }
        }

        public static bool PhraseUpdate(Phrases phrase)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Phrases>();
                int rows = connection.Update(phrase);

                //term successfully updated
                if (rows > 0)
                {
                    return true;
                }

                //term not successfully updated
                return false;
            }
        }

        public Database()
        {

        }

    }

}

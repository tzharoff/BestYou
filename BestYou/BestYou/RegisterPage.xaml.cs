using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BestYou
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public RegisterPage(string sEmail)
        {
            InitializeComponent();
            entryEmail.Text = sEmail;
        }

        private void buttonCreate_Clicked(object sender, EventArgs e)
        {
            //check if user exists
            //if user exists, give warning

            //check for empty/null passwords
            //if password is empty, give warning
            //if passwordmatch is empty, give warning
            //if password != passwordmatch, give warning

            //if the user is new, and passwords match (we aren't doing criteria)
            //then add user to database and go to login page

            Navigation.PushModalAsync(new LoginPage());

        }
    }
}
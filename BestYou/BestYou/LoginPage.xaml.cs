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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Clicked(object sender, EventArgs e)
        {
            //check database for username && password
            //if username not found, give a warning
            //if password not found, give a warning
            //if username && password don't match, give a warning

            //if everything is sucessful, then load the home page
            Navigation.PushModalAsync(new HomePage());

        }

        private void buttonRegister_Clicked(object sender, EventArgs e)
        {
            //load the registration page
            if (string.IsNullOrEmpty(entryEmail.Text))
            {
                Navigation.PushModalAsync(new RegisterPage());
            } else
            {
                Navigation.PushModalAsync(new RegisterPage(entryEmail.Text));
            }
        }
    }
}
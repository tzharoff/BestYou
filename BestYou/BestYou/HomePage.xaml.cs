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
    public partial class HomePage : TabbedPage
    {

        private User _user = null;

        public HomePage()
        {
            InitializeComponent();
        }

        //we'll use this class to save data to the database
        public HomePage(User user)
        {
            InitializeComponent();
            _user = user;
        }
    }
}
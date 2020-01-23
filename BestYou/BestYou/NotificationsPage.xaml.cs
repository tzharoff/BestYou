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
    public partial class NotificationsPage : ContentPage
    {
        public NotificationsPage()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NotificationsAdd());
        }
    }
}
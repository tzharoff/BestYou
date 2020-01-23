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
    public partial class NotificationsAdd : ContentPage
    {
        public NotificationsAdd()
        {
            InitializeComponent();
            tpNotifications.Time = System.DateTime.Now.TimeOfDay;

        }

        private void ButtonClose_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Your Notification has been added", "OK");
        }
    }
}
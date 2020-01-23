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
    public partial class PhrasesAddPage : ContentPage
    {
        public PhrasesAddPage()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            //code to see check for text
            //code to add the phrase (maybe we should see if the existing phrase exists first?)
            //push to the database
        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            //pop the modal, with the animation
            Navigation.PopModalAsync(true);
        }
    }
}
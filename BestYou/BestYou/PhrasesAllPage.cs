using System;

using Xamarin.Forms;

namespace BestYou
{
    public class PhrasesAllPage : ContentPage
    {
        public PhrasesAllPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


using System;

using Xamarin.Forms;

namespace KoreanFlashCards
{
    public class FlashCardPage : ContentPage
    {
        public FlashCardPage()
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


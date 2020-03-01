using System;
using System.Collections.Generic;
using PanCardView;

using Xamarin.Forms;

namespace KoreanFlashCards
{
    public partial class FlashcardPage : ContentPage
    {

        public FlashcardPage()
        {
            CardsView cardsView = new CardsView
            {
                ItemTemplate = new DataTemplate(() => new DefaultCardItemView()),
                BackgroundColor = Color.Black.MultiplyAlpha(.9)
            };

            InitializeComponent();

        }
    }
}

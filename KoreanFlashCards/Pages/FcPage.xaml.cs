﻿using System;
using System.Collections.Generic;
using PanCardView;
using Xamarin.Forms;

namespace KoreanFlashCards
{
    public partial class FcPage : ContentPage
    {

        public FcPage()
        {
            CardsView cardsView = new CardsView
            {
                ItemTemplate = new DataTemplate(() => new DefaultCardItemView()) //your template
            };
            cardsView.SetBinding(CardsView.ItemsSourceProperty, nameof(CardsSampleViewModel.Items));
            cardsView.SetBinding(CardsView.SelectedIndexProperty, nameof(CardsSampleViewModel.CurrentIndex));

            AbsoluteLayout.SetLayoutFlags(cardsView, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(cardsView, new Rectangle(0, 0, 1, 1)); InitializeComponent();

            Content = new AbsoluteLayout()
            {
                Children =
                {
                    cardsView
                }
            };

            BindingContext = new CardsSampleViewModel();
        }
    }
}

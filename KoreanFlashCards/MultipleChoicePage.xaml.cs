using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace KoreanFlashCards
{
    public partial class MultipleChoicePage : ContentPage
    {
        public MultipleChoicePage()
        {
            InitializeComponent();
            Deck deck = new Deck();
            deck.AddToDeck("Hello", "Hello");
            deck.AddToDeck("World", "World");
            deck.AddToDeck("Xamarin", "Xamarin");
            deck.AddToDeck("Cool", "Cool");
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}

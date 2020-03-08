using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace KoreanFlashCards
{
    public partial class CreateFlashcardPage : ContentPage
    {
        public ObservableCollection<Flashcard> FlashCards { get; set; } = new ObservableCollection<Flashcard>();

        public CreateFlashcardPage()
        {
            InitializeComponent();
            FlashCards.Add(new Flashcard());
            FlashCards.Add(new Flashcard
            {
                EnglishText = "Hello",
                KoreanText = "World"
            });
            listView.ItemsSource = FlashCards;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            FlashCards.Add(new Flashcard());
        }
    }
}

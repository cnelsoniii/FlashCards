using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoreanFlashCards
{
    public partial class StudyPage : ContentPage
    {
        public ObservableCollection<Flashcard> FlashCards { get; set; } = new ObservableCollection<Flashcard>();

        public StudyPage()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
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


        //Can be used to rotate stacklayout
        //public static async Task AnimateCardDrawing(Card card, Image image)
        //{
        //    image.TranslateTo(100, 0, 400);
        //    await image.RotateYTo(-90, 200);
        //    image.RotationY = -270;
        //    image.Source = card.ImagePath;
        //    image.RotateYTo(-360, 200);
        //    await image.TranslateTo(0, 0, 220);
        //    image.RotationY = 0;
        //}
    }
}

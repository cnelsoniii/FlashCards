using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KoreanFlashCards
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        Deck deck = new Deck();

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Flashcard flashcard = new Flashcard();
            if (flashcard != null)
            {
                flashcard.EnglishText = englishInput.Text;
                flashcard.KoreanText = koreanInput.Text;
                deck.AddToDeck(flashcard);

                englishLabel.Text = englishInput.Text;
                koreanLabel.Text = koreanInput.Text;
            }
        }

        void Navigate_To_QuizPage(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuizPage());
        }
    }
}

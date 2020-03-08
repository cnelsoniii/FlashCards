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
        public MainPage()
        {
            InitializeComponent();
        }

        void MatchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MatchPage());
        }

        void StudyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StudyPage());
        }

        void WriteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WritePage());
        }

        void MultipleChoiceButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MultipleChoicePage());
        }
    }
}

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoreanFlashCards
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public QuizPage()
        {
            InitializeComponent();

            wordDisplay.Text = "Word 4";

            Items = new ObservableCollection<string>
            {
                "Word 1",
                "Word 2",
                "Word 3",
                "Word 4"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            if(wordDisplay.Text == e.Item.ToString())
            {
                await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace KoreanFlashCards
{
    public partial class MatchPage : ContentPage
    {
        Button firstClicked;
        Button secondClicked;


        public MatchPage()
        {
            InitializeComponent();
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
                firstClicked.BackgroundColor = Color.Blue;
                return;
            }

            secondClicked = clickedButton;
            secondClicked.BackgroundColor = Color.Blue;

            if (firstClicked.Text == secondClicked.Text && firstClicked.Id != secondClicked.Id)
            {
                firstClicked.BackgroundColor = Color.Green;
                secondClicked.BackgroundColor = Color.Green;
                firstClicked.IsVisible = false;
                secondClicked.IsVisible = false;
                firstClicked.IsEnabled = false;
                secondClicked.IsEnabled = false;
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                firstClicked.BackgroundColor = Color.LightGray;
                secondClicked.BackgroundColor = Color.LightGray;
                firstClicked = null;
                secondClicked = null;
            }
        }
    }
}

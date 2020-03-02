﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoreanFlashCards
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MatchPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

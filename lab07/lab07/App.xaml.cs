﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab07
{
    public partial class App : Application
    {
        public App()
            //sinche
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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

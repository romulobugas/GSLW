﻿namespace GSLW.Desktop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Views.Splash.SplashPage();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MapTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MapTest.MainPage();  
            // PSH 05/19/17 : now published to git hub
            // hello this is updated. 
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

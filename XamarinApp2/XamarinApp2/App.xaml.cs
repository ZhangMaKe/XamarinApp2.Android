using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace XamarinApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new XamarinApp2.MainPage();
            MainPage = new XamarinApp2.MainPage();
        }

        protected override void OnStart()
        {
			// Handle when your app starts
			MobileCenter.Start("android=c6080f53-bc34-4c43-952e-c7c5dc5fdc27;" +
				   "ios={Your iOS App secret here}",
				   typeof(Analytics), typeof(Crashes));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ActivityTracker
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("people.db3");

        public static ActivityRepository ActivityRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            ActivityRepo = new ActivityRepository(dbPath);

            MainPage = new NavigationPage(new ActivityTracker.LogonPage());
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

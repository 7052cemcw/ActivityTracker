using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ActivityTracker.Models;
using ActivityTracker.Pages;

namespace ActivityTracker
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Constructor for the MainPage
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executed when New Activity button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public async void OnNewActivityClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            //go to the database and save the name and description picked up from the UI.
            await App.ActivityRepo.AddNewActivityAsync(ActivName.Text, ActivDesc.Text);
            //display the message on the UI.
            StatusMessage.Text = App.ActivityRepo.StatusMessage;
        }

        public async void OnGetAllActivitiesClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            //Fetch all activities saved in the database
            List<Activity> people = await App.ActivityRepo.GetAllActivitiesAsync();
            //Set the list of activities fetched on the UI
            ActivityList.ItemsSource = people;
        }

        /*public async void OnCompletedClicked(object sender, EventArgs args)
        {
            int IDselected = ActivityList.
        }*/

        public async void OnSetCompleted(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SetCompletedPage());
        }
    }
}

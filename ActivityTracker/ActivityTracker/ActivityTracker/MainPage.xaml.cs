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

        public MainPage()
        {
            InitializeComponent();
            

            
        }

        public async void OnNewActivityClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            await App.ActivityRepo.AddNewActivityAsync(ActivName.Text, ActivDesc.Text);
            StatusMessage.Text = App.ActivityRepo.StatusMessage;
        }

        public async void OnGetAllActivitiesClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            List<Activity> people = await App.ActivityRepo.GetAllActivitiesAsync();
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

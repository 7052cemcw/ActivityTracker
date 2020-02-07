using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActivityTracker.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetCompletedPage : ContentPage
    {
        public SetCompletedPage()
        {
            InitializeComponent();
        }

        public async void OnSaveClicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(IDentry.Text))
            {
                message.Text = "please enter ID";
            }
            else
            {
                
                await Navigation.PopModalAsync();
            }
            
        
        }

        public async void OnCancelClicked(object sender, EventArgs e)
        {
            
        await Navigation.PopModalAsync();
        }
    }
}
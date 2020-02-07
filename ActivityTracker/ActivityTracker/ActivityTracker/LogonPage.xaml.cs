using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActivityTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogonPage : ContentPage
    {
        /// <summary>
        /// Contructor for the logon page.
        /// </summary>
        public LogonPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This code is executed when login button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLogOnClicked(object sender, EventArgs e)
        {
            //hardcoded username and password
            if (username.Text == "iyad" && password.Text == "123")
            {
                //if credentials are correct, move to MainPage
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                message.Text = "username or password invalid";
            }
        }
    }
}
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
        public LogonPage()
        {
            InitializeComponent();
        }

        private void OnLogOnClicked(object sender, EventArgs e)
        {
            if (username.Text == "iyad" && password.Text == "123")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                message.Text = "username or password invalid";
            }
            
        }
    }
}
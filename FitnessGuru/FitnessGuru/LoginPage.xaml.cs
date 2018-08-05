using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FitnessGuru
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
		private async void BtnReset(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResetPage());
        }

    }
}

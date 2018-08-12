using System;
using System.Collections.Generic;
using FitnessGuru.Model;
using Xamarin.Forms;

namespace FitnessGuru
{
    public partial class MenuPage : ContentPage
    {
        

        public MenuPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.GreenTextColor;
            lblMenu.TextColor = Color.White;

        }
		private async void BtnLogin(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void BtnReset(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResetPage());
        }
		private async void BtnLevel(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LevelPage());
        }
		private async void BtnEHabits(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EHabitsPage());
        }
		private async void BtnWDays(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new WDaysPage());
        }
        private async void BtnLogout(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }
}

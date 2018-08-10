using System;
using System.Collections.Generic;
using FitnessGuru.Data;
using FitnessGuru.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FitnessGuru
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
            UserLogin();
        }
		private async void BtnReset(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResetPage());
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Login.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            Login_Icon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_Login.Focus();
        }


        public async void UserLogin()
        {

            //HttpClient client = new HttpClient();
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync("http://www.mocky.io/v2/5b6d9499330000a827a36e7e");
            string JsonData = await response.Content.ReadAsStringAsync();
            UserDetails User = new UserDetails();


            if (JsonData != "null")
            {
                User = JsonConvert.DeserializeObject<UserDetails>(JsonData);
                Lbl_Login.Text = User.ToString();
            }

        }



        void LoginClickedAsync(object sender, EventArgs eventArgs)
        {

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if(user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "ok");
            }
            else
            {
                DisplayAlert("Login", "Username or Password is Incorrect", "ok");
            }
        }
    }
}

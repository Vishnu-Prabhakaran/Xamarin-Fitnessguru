using System;
using System.Collections.Generic;
using FitnessGuru.Model;
using Xamarin.Forms;

namespace FitnessGuru
{

    public partial class WDaysPage : ContentPage
    {

        public WDaysPage()
        {
            InitializeComponent();
            Init();

        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblAvailability.TextColor = Constants.GreenTextColor;
        }
       

        void Tgld_Mon(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Mo.Text = "Enabled";
            Swh_Mo.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Tue(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Tu.Text = "Enabled";
            Swh_Tu.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Wed(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_We.Text = "Enabled";
            Swh_We.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Thu(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Th.Text = "Enabled";
            Swh_Th.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Fri(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Fr.Text = "Enabled";
            Swh_Fr.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Sat(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Sa.Text = "Enabled";
            Swh_Sa.TextColor = Constants.GreenTextColor;
        }
        void Tgld_Sun(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Swh_Su.Text = "Enabled";
            Swh_Su.TextColor = Constants.GreenTextColor;
        }
    }
}


using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FitnessGuru
{

    public partial class WDaysPage : ContentPage
    {

        public WDaysPage()
        {
            InitializeComponent();


        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool value = e.Value;
            sv.Text = value.ToString();
        }
    }
}


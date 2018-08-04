using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using static System.Console;
using System.Diagnostics;

namespace FitnessGuru
{
    public partial class Workout : ContentPage
    {

        //switch
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            throw new NotImplementedException();
        }


        //Workout List view
        public Workout()
        {
            InitializeComponent();
            GetData();
        }

        public async void GetData()
        {

            //HttpClient client = new HttpClient();
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync("http://demo7712681.mockable.io/workout");
            string JsonData = await response.Content.ReadAsStringAsync();
            WorkoutLists ObjWorkoutList = new WorkoutLists();


            if (JsonData != "null")
            {
                ObjWorkoutList = JsonConvert.DeserializeObject<WorkoutLists>(JsonData);

            }
            WorkoutListView.ItemsSource = ObjWorkoutList.workouts;
        }
    }

}

    //protected override void OnAppearing()
    //{
    //base.OnAppearing();
    //var workoutList = new List<WList>
    //{
    //    new WList {Id=1 , Name="Vishnu", Excercise="Leg Day", IsDone=false, UpdatedAt=DateTime.Now},
    //    new WList {Id=1 , Name="Prabhakaran", Excercise="Leg Day", IsDone=false, UpdatedAt=DateTime.Now},
    //    new WList {Id=1 , Name="Aparna", Excercise="Dance", IsDone=false, UpdatedAt=DateTime.Now.AddDays(3)},
    //};


    //}

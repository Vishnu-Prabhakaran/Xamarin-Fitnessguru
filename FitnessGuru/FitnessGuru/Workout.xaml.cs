using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using static System.Console;
using System.Diagnostics;
using FitnessGuru.Model;

namespace FitnessGuru
{
    public partial class Workout : ContentPage
    {
        public const string V = "Completed";
        public event EventHandler<SelectedItemChangedEventArgs> SelectedOrToggled;
      
        //Workout List view
        public Workout()
        {
            InitializeComponent();
            GetData();
            Init();
            BindingContext = new  WorkoutDays();
        }
      
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lbnlRoutine.TextColor = Constants.GreenTextColor;

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



        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var view = sender as BindableObject;
            SelectedOrToggled?.Invoke(this, new
            SelectedItemChangedEventArgs(view.BindingContext));
        }

        //XAML usage


       

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

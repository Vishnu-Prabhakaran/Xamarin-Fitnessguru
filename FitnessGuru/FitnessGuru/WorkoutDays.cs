using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FitnessGuru
{
    public class WorkoutDays : INotifyPropertyChanged
    {
        public List<Days> DayList { get; set; }

        public WorkoutDays() 
        {
            DayList = GetDays().OrderBy(t => t.Value).ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private Days _selectedDay { get; set; }
        public Days SelectedDay
        {
            get { return _selectedDay;}
            set {
                if (_selectedDay != value)
                {
                    _selectedDay = value;
                    //code
                    //MyDays = "Selected Day : " + _selectedDay.Value;
                    MyDays = URL_M + _selectedDay.Value;
                }
            }
        }


        private string _myDays;
        private string URL_M;
        public string MyDays 
        {
            get { return _myDays; }
            set 
            {
                if (_myDays != value)
                {
                    _myDays = value;
                    OnPropertyChanged(); 

                    URL_M = "http://demo7712681.mockable.io/";
                }
            }
        }


        public List<Days> GetDays()
        {
            var allDays = new List<Days>()
            {
                new Days() { Key =1, Value= "Monday"},
                new Days() { Key = 2, Value = "Tuesday" },
                new Days() { Key = 3, Value = "Wednesday" },
                new Days() { Key = 4, Value = "Thursday" },
                new Days() { Key = 5, Value = "Friday" },
                new Days() { Key = 6, Value = "Saturday" },
                new Days() { Key = 7, Value = "Sunday" },
            };
            return allDays;
        }


    }
    public class Days 
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }




}


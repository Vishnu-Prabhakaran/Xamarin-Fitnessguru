using System;
using System.Collections.Generic;


namespace FitnessGuru
{


    public class ClassWorkout
    {

        public string id { get; set; }

        public string name { get; set; }

        public string excercise { get; set; }

        //public bool IsDone { get; set; }

        //public DateTime UpdatedAt {get; set; }
    }

    public class WorkoutLists
    {
        public List<ClassWorkout> workouts { get; set; }
    }

}


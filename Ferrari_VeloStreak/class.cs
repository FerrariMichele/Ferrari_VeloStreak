using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_VeloStreak
{
    public class Rider
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public int Fcmax { get; set; }
        public int Ftp { get; set; }
        public List<Bike> Bikes { get; set; }
        public List<TrainingSession> TrainingSessions { get; set; }

        public Rider()
        {
            Bikes = new List<Bike>();
            TrainingSessions = new List<TrainingSession>();
        }
    }

    // Bike class
    public class Bike
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public float Weight { get; set; }

        public Bike() { }
    }

    // TrainingSession class
    public class TrainingSession
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<Exercise> Exercises { get; set; }

        public TrainingSession()
        {
            Exercises = new List<Exercise>();
        }
    }

    // Abstract Exercise class
    public abstract class Exercise
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Zone { get; set; }
        public int Power { get; set; }
        public int Fc { get; set; }

        protected Exercise() { }
    }
}

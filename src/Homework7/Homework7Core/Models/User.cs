using Homework7Core.Enums;
using System.Collections.Generic;

namespace Homework7Core.Models
{
    public class User
    {
        public User()
        {
        }

        public User(
            string fullName,
            double weight,
            int height,
            int age,
            Gender gender)
        {
            FullName = fullName;
            Weight = weight;
            Height = height;
            Age = age;
            Gender = gender;
        }

        public string FullName { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Run> Runs { get; set; } = new List<Run>();
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}

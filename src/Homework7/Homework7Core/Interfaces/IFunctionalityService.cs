using Homework7Core.Models;
using System;
using System.Collections.Generic;

namespace Homework7Core.Interfaces
{
    public interface IFunctionalityService
    {
        event Action<string, DateTime> Notification;

        DateTime Execute(string message);

        void ShowAll(User user);

        void ShowRuns(User user);

        void ShowExercises(User user);

        public IEnumerable<int> BioTraccerPpg()
        {
            var list = new List<int>();
            var rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(40, 100));
            }

            return list;
        }
    }
}

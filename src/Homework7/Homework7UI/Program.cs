using Homework7Core.Enums;
using Homework7Core.Interfaces;
using Homework7Core.Manager;
using Homework7Core.Models;
using Homework7Core.Sirvices;
using System;
using System.Threading;

namespace Homework7UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IStatisticService statisticService = new StatisticService();
            IFunctionalityService functionalityService = new FunctionalityService();
            functionalityService.Notification += NotificationManager.Show;
            var user = new User("Mikita", 65.1, 175, 20, Gender.Male);

            var run = new Run
            {
                Name = "Naliboki Race",
                Speed = 6.7,
            };
            var time1 = 4000;
            run.Start = functionalityService.Execute($"Start {run.Name}: ");
            Thread.Sleep(time1);
            run.End = functionalityService.Execute($"End {run.Name}: ");
            run.Data = (decimal)(time1 * run.Speed);

            user.Runs.Add(run);

            functionalityService.ShowRuns(user);

            var exercise = new Exercise
            {
                Name = "Jump",
                Count = 200,
            };

            var time2 = 5000;
            exercise.Start = functionalityService.Execute($"Start {exercise.Name}: ");
            Thread.Sleep(time2);
            exercise.End = functionalityService.Execute($"End {exercise.Name}: ");
            exercise.Data = ((double)exercise.Count / time2) * 1000;

            user.Exercises.Add(exercise);

            Console.WriteLine("=======");

            functionalityService.ShowAll(user);

            Console.WriteLine("=======");

            var bioTrackerData = functionalityService.BioTraccerPpg();
            foreach (var val in bioTrackerData)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("=======");

            var statistic = statisticService.Get(user, bioTrackerData);

            Console.ReadKey();
        }
    }
}

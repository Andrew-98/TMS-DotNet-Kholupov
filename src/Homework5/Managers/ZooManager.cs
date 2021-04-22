using Homework5.Interfaces;
using Homework5.Models;
using System;
using System.Collections.Generic;

namespace Homework5.Managers
{
    public class ZooManager : IZooManager, ICanInteract
    {
        public List<AnimalBase<int>> Animals { get; set; } = new List<AnimalBase<int>>();

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, {animal.Age}");
            }
        }

        public void YouCanInteractWithIt()
        {
            Animals.Add(new Fox
            {
                Name = "Foxi",
                Age = 2,
            });

            Show();

            Console.WriteLine("Now you can.");
        }
    }
}

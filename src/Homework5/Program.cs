using Homework5.Interfaces;
using Homework5.Managers;
using Homework5.Models;
using System;

namespace Homework5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fox = new Fox
            {
                Name = "Fox",
                Age = 1,
            };

            var bird = new Bird
            {
                Name = "Bird",
                Age = 3,
            };

            IZooManager zooManager = new ZooManager();
            zooManager.Animals.Add(fox);
            zooManager.Animals.Add(bird);

            fox.Say();
            bird.Fly();

            zooManager.Show();

            ICanInteract canInteract = new ZooManager();
            canInteract.YouCanInteractWithIt();

            Console.ReadKey();
        }
    }
}

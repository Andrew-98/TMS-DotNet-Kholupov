using System;

namespace Homework5.Models
{
    public class Bird : AnimalBase<int>
    {
        public void Fly()
        {
            Console.WriteLine("I belive I can fly!");
        }
    }
}

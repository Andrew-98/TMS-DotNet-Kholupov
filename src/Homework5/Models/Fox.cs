using System;

namespace Homework5.Models
{
    public class Fox : AnimalBase<int>
    {
        public void Say()
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}

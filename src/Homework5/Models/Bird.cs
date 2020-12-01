using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public class Bird : AnimalBase<int>
    {
        public void Fly()
        {
            Console.WriteLine("I belive Ican fly");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

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

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public abstract class AnimalBase<T>
    {
        public string Name { get; set; }
        public T Age { get; set; }
    }
}

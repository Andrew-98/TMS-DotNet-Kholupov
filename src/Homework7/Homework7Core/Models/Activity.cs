﻿using System;

namespace Homework7Core.Models
{
    public abstract class Activity<T> where T : struct
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public T Data { get; set; }
    }
}

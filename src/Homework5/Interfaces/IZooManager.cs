using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Interfaces
{
    public interface IZooManager
    {
        List<AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}

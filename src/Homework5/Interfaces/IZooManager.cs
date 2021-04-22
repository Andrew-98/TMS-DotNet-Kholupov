using Homework5.Models;
using System.Collections.Generic;

namespace Homework5.Interfaces
{
    public interface IZooManager
    {
        List<AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}

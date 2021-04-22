using Homework7Core.Models;
using System.Collections.Generic;

namespace Homework7Core.Interfaces
{
    public interface IStatisticService
    {
        Statistic Get(User user, IEnumerable<int> data);
    }
}

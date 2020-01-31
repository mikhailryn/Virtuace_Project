using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject
{
    public interface IDatabase
    {
        string GetTrainFrom(string name);
        string GetTrainWhere(string name);
        DateTime GetTrainDateBegin(string name);
    }
}

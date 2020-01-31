using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtuace_TrainProject_BL;

namespace Virtuace_TrainProject_DAL
{
    public interface IDatabase
    {
        string[] GetDirections();
        List<Train> GetTrains();
        List<Station> GetStations();
    }
}

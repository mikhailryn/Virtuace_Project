using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject_BL
{
    public class Ticket
    {
        public string TrainNumber { get; private set; }
        public string StationNumber { get; private set; }
        public string RailcarType { get; private set; }
        public double StationFares { get; private set; }
        public Ticket(string trainNumber,
                     string stationNumber,
                     string railcarType,
                     double stationFares
                    )
        {
            TrainNumber = trainNumber;
            StationNumber = stationNumber;
            RailcarType = railcarType;
            StationFares = stationFares;
        }
    }
}

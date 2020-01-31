using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject_BL
{
    public class Station
    {
        public string TrainNumber { get; private set; }
        public string StationNumber { get; private set; }
        public string StationName { get; private set; }
        public string StationTimeBegin { get; private set; }
        public string StationTimeEnd { get; private set; }
        public double StationCoupeFares { get; private set; }
        public double StationPlatzkarteFares { get; private set; }
        public Station()
        {
            TrainNumber = "";
            StationNumber = "";
            StationName = "";
            StationTimeBegin = "";
            StationTimeEnd = "";
            StationCoupeFares = 0;
            StationPlatzkarteFares = 0;
        }
        public Station(string trainNumber,
                       string stationNumber,
                       string stationName,
                       string stationTimeBegin,
                       string stationTimeEnd,
                       double stationCoupeFares,
                       double stationPlatzkarteFares
                       )
        {
            TrainNumber = trainNumber;
            StationNumber = stationNumber;
            StationName = stationName;
            StationTimeBegin = stationTimeBegin;
            StationTimeEnd = stationTimeEnd;
            StationCoupeFares = stationCoupeFares;
            StationPlatzkarteFares = stationPlatzkarteFares;
        }
    }
}

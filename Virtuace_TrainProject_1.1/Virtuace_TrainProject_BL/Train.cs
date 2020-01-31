using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject_BL
{
    public class Train
    {
        public string TrainNumber { get; private set; }
        public string TrainDirection { get; private set; }
        public string TrainFrom { get; private set; }
        public string TrainTo { get; private set; }
        public string TrainDateBegin { get; private set; }
        public string TrainDateEnd { get; private set; }
        public int TrainCoupeTot { get; private set; }
        public int TrainPlatzkarteTot { get; private set; }
        public int TrainCoupeRest { get; private set; }
        public int TrainPlatzkarteRest { get; private set; }

        public Train(string trainNumber,
                     string trainDirection,
                     string trainFrom,
                     string trainTo,
                     string trainDateBegin,
                     string trainDateEnd,
                     int trainCoupeTot,
                     int trainPlatzkarteTot,
                     int trainCoupeRest,
                     int trainPlatzkarteRest)
        {
            TrainNumber = trainNumber;
            TrainDirection = trainDirection;
            TrainFrom = trainFrom;
            TrainTo = trainTo;
            TrainDateBegin = trainDateBegin;
            TrainDateEnd = trainDateEnd;
            TrainCoupeTot = trainCoupeTot;
            TrainPlatzkarteTot = trainPlatzkarteTot;
            TrainCoupeRest = trainCoupeRest;
            TrainPlatzkarteRest = trainPlatzkarteRest;
        }
    }
}

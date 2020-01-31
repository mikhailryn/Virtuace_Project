using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtuace_TrainProject_BL;
using Virtuace_TrainProject_DAL;
using static System.Console;

namespace Virtuace_TrainProject_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = BookingDatabase.Instance;
            var rf = new BookingRecordFinder();

            var StationEntry = new Station();
            List<Ticket> ticketCollection = new List<Ticket>();

            WriteLine();
            string userDirection, userTrainNumber, userRailcarType, userStationNumber;
            double userStationFires;

            rf.DirectionsAllView();

            WriteLine("Введите наименование направления:");
            userDirection = Console.ReadLine();
            userDirection = rf.GetOneDirection(userDirection);

            rf.TrainsAllView(userDirection);

            WriteLine("Введите номер поезда:");
            userTrainNumber = Console.ReadLine();
            userTrainNumber = rf.GetOneTrain(userTrainNumber);

            rf.StationsAllView(userTrainNumber);

            WriteLine("Введите номер станции:");
            userStationNumber = Console.ReadLine();
            StationEntry = rf.GetOneStationEntry(userTrainNumber, userStationNumber);

            WriteLine("Введите тип вагона (1 - купе, 2 - плацкарт):");
            userRailcarType = Console.ReadLine();

            if (userRailcarType == "1")
                userStationFires = StationEntry.StationCoupeFares;
            else
                userStationFires = StationEntry.StationPlatzkarteFares;

            ticketCollection.Add(new Ticket(userTrainNumber, userStationNumber, userRailcarType, userStationFires));

            foreach (var entry in ticketCollection)
            {
                Console.WriteLine($"Стоимость билета: {entry.StationFares}");
            }

            ReadKey();
        }
    }
}

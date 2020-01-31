using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtuace_TrainProject_BL;
using static System.Console;

namespace Virtuace_TrainProject_DAL
{
        public class BookingRecordFinder
        {
            public void DirectionsAllView()
            {
                WriteLine("Путешествуй популярными направлениями:");
                var listDirections = from direction in BookingDatabase.Instance.GetDirections() orderby direction ascending select direction;
                StringBuilder sbDirections = new StringBuilder();
                foreach (string entry in listDirections)
                {
                    sbDirections.Append(entry + "\n");
                }
                Console.WriteLine(sbDirections.ToString());
            }
            public string GetOneDirection(string Direction)
            {
                string result = "";
                var listDirections = from direction in BookingDatabase.Instance.GetDirections() where direction.Contains(Direction) select direction;
                foreach (var entry in listDirections)
                {
                    Console.WriteLine($"Направление: {entry}");
                    result = entry;
                }
                return result;
            }
            public void TrainsAllView(string Direction)
            {
                var listTrains = from train in BookingDatabase.Instance.GetTrains() where train.TrainDirection.Contains(Direction) orderby train.TrainNumber ascending select train;
                StringBuilder sbTrains = new StringBuilder();
                foreach (var entry in listTrains)
                {
                    sbTrains.AppendLine($"{entry.TrainNumber} - {entry.TrainFrom} - {entry.TrainTo} - {entry.TrainDateBegin} - {entry.TrainDateEnd}");
                }
                Console.WriteLine(sbTrains.ToString());
            }
            public string GetOneTrain(string TrainNumber)
            {
                string result = "";
                var listTrains = from train in BookingDatabase.Instance.GetTrains() where train.TrainNumber.Contains(TrainNumber) select train;
                foreach (var entry in listTrains)
                {
                    Console.WriteLine($"Маршрут поезда: {entry.TrainNumber}. Свободных мест купе: {entry.TrainCoupeRest} плацкарт: {entry.TrainPlatzkarteRest}");
                    result = entry.TrainNumber;
                }
                return result;
            }
            public void StationsAllView(string TrainNumber)
            {
                var listStations = from station in BookingDatabase.Instance.GetStations() where station.TrainNumber.Contains(TrainNumber) orderby station.StationNumber ascending select station;
                StringBuilder sbStations = new StringBuilder();
                foreach (var entry in listStations)
                {
                    sbStations.AppendLine($"{entry.StationNumber} - {entry.StationName} - {entry.StationTimeBegin} - {entry.StationTimeEnd}");
                }
                Console.WriteLine(sbStations.ToString());
            }
            public Station GetOneStationEntry(string TrainNumber, string StationNumber)
            {
                var result = new Station();
                var listStations = from station in BookingDatabase.Instance.GetStations() where station.TrainNumber.Contains(TrainNumber) && station.StationNumber.Contains(StationNumber) select station;
                foreach (var entry in listStations)
                {
                    Console.WriteLine($"Номер поезда: {entry.TrainNumber}. Станция: {entry.StationName}. Прибытие: {entry.StationTimeBegin}. Стоимость купе: {entry.StationCoupeFares} плацкарт: {entry.StationPlatzkarteFares} ");
                    result = entry;
                }
                return result;
            }
        }
    }


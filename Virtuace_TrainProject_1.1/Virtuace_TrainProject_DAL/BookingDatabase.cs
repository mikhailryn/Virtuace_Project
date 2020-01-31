using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtuace_TrainProject_BL;
using static System.Console;

namespace Virtuace_TrainProject_DAL
{
    public class BookingDatabase : IDatabase
    {
        private string[] directions;
        private List<Train> trains;
        private List<Station> stations;

        private static int instanceCount;
        public static int Count => instanceCount;

        private BookingDatabase()
        {
            WriteLine("Initializing database");

            directions = new[]{ "Львов",
                                "Харьков",
                                "Одесса",
                                "Днепр-Главный",
                                "Винница",
                                "Запорожье",
                                "Ивано-Франковск"};

            var train1 = new Train("148 К", "Одесса", "Киев-Пассажирский", "Одесса-Главная", "26.01.2020 15:46", "27.01.2020 05:13", 144, 486, 144, 486);
            var train2 = new Train("763 О", "Одесса", "Киев-Пассажирский", "Одесса-Главная", "26.01.2020 16:30", "26.01.2020 23:44", 144, 486, 144, 486);
            var train3 = new Train("145 К", "Одесса", "Киев-Пассажирский", "Измаил", "26.01.2020 17:40", "27.01.2020 04:00", 144, 486, 144, 486);
            var train4 = new Train("105 К", "Одесса", "Киев-Пассажирский", "Одесса-Главная", "26.01.2020 21:15", "27.01.2020 05:59", 144, 486, 144, 486);
            trains = new List<Train> { train1, train2, train3, train4 };

            var station1 = new Station("763 О", "1", "Киев - Пассажирский", "", "16:30", 0, 0);
            var station2 = new Station("763 О", "2", "Винница", "18:53", "18:55", 312, 156);
            var station3 = new Station("763 О", "3", "Жмеринка", "19:30", "19:32", 468, 234);
            var station4 = new Station("763 О", "4", "Вапнярка", "20:23", "20:24", 624, 312);
            var station5 = new Station("763 О", "5", "Подольск", "21:41", "21:42", 936, 468);
            var station6 = new Station("763 О", "6", "Одесса - Главная", "23:44", "", 1092, 546);
            stations = new List<Station> { station1, station2, station3, station4, station5, station6 };

        }
        public string[] GetDirections()
        {
            return directions;
        }
        public List<Train> GetTrains()
        {
            return trains;
        }
        public List<Station> GetStations()
        {
            return stations;
        }

        // laziness + thread safety
        private static Lazy<BookingDatabase> instance = new Lazy<BookingDatabase>(() =>
        {
            instanceCount++;
            return new BookingDatabase();
        });

        public static IDatabase Instance => instance.Value;
    }
}

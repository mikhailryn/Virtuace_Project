using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject
{
    public class TrainDatabase : IDatabase
    {

        private Dictionary<string, string> train_from;
        private Dictionary<string, string> train_where;
        private Dictionary<string, DateTime> train_date_begin;

        
        private static int instanceCount;
        public static int Count => instanceCount;

        //Инициализация БД в конструкторе
        private TrainDatabase()
        {
            Console.WriteLine("Initializing database");

            //Считывание файла 
            train_from = File.ReadAllLines(
              Path.Combine(
                new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "trains.txt")
              )
              .Batch(11)
              .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => list.ElementAt(1).Trim());

            train_where = File.ReadAllLines(
              Path.Combine(
                new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "trains.txt")
              )
              .Batch(11)
              .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => list.ElementAt(2).Trim());

            train_date_begin = File.ReadAllLines(
              Path.Combine(
                new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "trains.txt")
              )
              .Batch(11)
              .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => DateTime.Parse(list.ElementAt(3).Trim()));

            Console.WriteLine($"Всего записей {train_from.Count}");
            foreach (var SubElement in train_from)
            {
                Console.WriteLine($"{SubElement.Key} отправляется из {SubElement.Value} в {train_where[SubElement.Key]}."
                    + $" Дата отпраления {train_date_begin[SubElement.Key].ToString("D")}");
            }

        }
        //Методы которые возвращают информацию из таблицы БД
        public string GetTrainFrom(string name)
        {
            return train_from[name];
        }

        public string GetTrainWhere(string name)
        {
            return train_where[name];
        }

        public DateTime GetTrainDateBegin(string name)
        {
            return train_date_begin[name];
        }

        //Создание Singleton DB 
        private static Lazy<TrainDatabase> instance = new Lazy<TrainDatabase>(() =>
        {
            instanceCount++;
            return new TrainDatabase();
        });

        //Выдача экземпляра ДБ наружу
        public static IDatabase Instance => instance.Value;
    }
}

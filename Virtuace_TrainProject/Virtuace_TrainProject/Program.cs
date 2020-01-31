using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton
            var db = TrainDatabase.Instance;

            //var train = "IC+763 Д";
            //WriteLine($"\n{train} отправляется из: {db.GetTrainFrom(train)}");
            Console.WriteLine();
            var rf = new TrainRecordFinder();

            var names = new[] { "148 К", "105 К" };

            int tp = rf.TotalTrain(names);

            Console.WriteLine($"{"148 К and 105 К"} Total quantity {tp}");
            rf.ElementView(names);

            Console.ReadKey();
        }
    }
}

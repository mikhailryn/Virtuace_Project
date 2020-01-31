using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuace_TrainProject
{
    //Поиск по базе 
    public class TrainRecordFinder
    {
        //Метод возвращает расписание всех поездов 
        public int TotalTrain(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                result += 1; // TrainDatabase.Instance.GetTrainFrom(name);
            return result;
        }

        public void ElementView(IEnumerable<string> names)
        {
            foreach (var name in names)
                Console.WriteLine($"{name} отправляется из {TrainDatabase.Instance.GetTrainFrom(name)} в {TrainDatabase.Instance.GetTrainWhere(name)}. " +
                    $"Дата отпраления {TrainDatabase.Instance.GetTrainDateBegin(name)}");
        }
    }
}

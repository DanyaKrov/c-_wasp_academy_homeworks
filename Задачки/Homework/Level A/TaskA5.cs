using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            List<int> list1 = new List<int>();
            do
            {
                list1.Add(number);
                number /= 10;
            } while (number > 9);
            list1.Add(number);
            list1.Reverse();
            return list1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> OddNumbers(List<int> arr, int n)
        {
            List<int> list1 = new List<int>();
            arr.Reverse();
            int kol = 0;
            foreach (int i in arr)
            {
                if (Math.Abs(i) % 2 == 1)
                {
                    kol++;
                    list1.Add(i);
                }
                if (kol == n)
                    break;
            }
            list1.Reverse();
            return list1;
        }
    }
}

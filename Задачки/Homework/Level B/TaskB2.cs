using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            int x, sum1, sum2, number1, number;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    number1 = list[i]; number = list[j]; sum1 = 0; sum2 = 0;
                    do
                    {
                        sum1 += number1 % 10;
                        number1 /= 10;
                    } while (number1 > 9);
                    do
                    {
                        sum2 += number % 10;
                        number /= 10;
                    } while (number > 9);
                    if (sum1 > sum2)
                    {
                        x = list[i];
                        list[i] = list[j];
                        list[j] = x;
                    }
                }
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А2.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию VeryEven(number), которая определяет является ли число "очень четным".
    // Однозначное число "очень четное", если оно четное. Числа больше 10 "очень четные",
    // если сумма их цифр - "очень четное" число.
    //
    // Примеры:
    // VeryEven(88) => false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 - нечетное;
    // VeryEven(222) => true -> 2 + 2 + 2 = 8 => 8 - четное.
    public static class TaskA2
    {
        public static int Sum(int number)
        {
            int sum = number % 10; //сумма цифр числа
            do
            {
                number /= 10;
                sum += number % 10;
            } while (number > 9);
            if (sum >= 10)
                sum = Sum(sum);
            return sum;
        }
        public static bool VeryEven(int number)
        {
            int sum = Sum(number);
            return (sum % 2 == 0);
        }
    }
}

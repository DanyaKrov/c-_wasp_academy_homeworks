using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C2.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию ChangeCent(int money), которая принимает количество американской валюты в центах и
    // возвращает список из четырех значений, который показывает наименьшее количество монет, используемых для составления этой суммы. 
    // Рассматриваются только монетные номиналы: Pennie (1 цент), Nickel (5 центов), Dime (10 центов) and Quarter (25 центов).
    // Возвращаемый список должен быть формата [кол-во Pennie, кол-во Nickel, кол-во Dime, кол-во Quarter].
    // Если в функцию передается вещественное число, его значение сперва должно быть округлено в меньшую сторону.
    // 
    // Пример:
    // ChangeCent(56) ==> [1,1,0,2] --> 1 * 1 + 1 * 5 + 0 * 10 + 2 * 25.
    public static class TaskC2
    {
        public static List<int> ChangeCent(double money)
        {
            money = Math.Floor(money);
            List<int> list = new List<int> { 0, 0, 0, 0};
            while (money >= 25)
            {
                money -= 25;
                list[3] += 1;
            }
            while (money >= 10)
            {
                money -= 10;
                list[2] += 1;
            }
            while (money >= 5)
            {
                money -= 5;
                list[1] += 1;
            }
            while (money >= 1)
            {
                money -= 1;
                list[0] += 1;
            }
            return list;
        }
    }
}

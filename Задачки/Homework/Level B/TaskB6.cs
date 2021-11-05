using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            string ans = "";
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                number = i;
                if (s[i] != ' ')
                {
                    while (number < s.Length - 1 && s[number] != ' ')
                    {
                        number++;
                    }
                    if (s[number] == ' ')
                        number--;
                    for (int _ = number; _ >= i; _--)
                    {
                        ans += s[_];
                    }
                    i = number;
                }
                else
                    ans += " ";

            }
            return ans;
        }
    }
}

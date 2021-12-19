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
            char[] mas;
            string[] list1 = s.Split(' ');
            foreach(string i in list1)
            {
                mas = i.ToCharArray();
                mas.Reverse();
                ans += $"{mas.ToString()} ";
            }
            ans = ans.Remove(ans.Length - 1);
            return "";
        }
    }
}

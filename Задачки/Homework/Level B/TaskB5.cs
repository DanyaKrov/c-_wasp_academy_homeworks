using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            string ans = "";
            for (int i = 0; i < text.Count + 2; i++)
                ans += symbol;
            int max = 0;
            foreach (string i in text)
            {
                if (i.Length > max)
                    max = i.Length;
            }
            foreach (string i in text) {
                ans += "\n";
                ans += $"\n{symbol} {i}";
                for (int j = 0; j < max + 1; j++)
                    ans += " ";
                ans += symbol;
                ans += "\n";
            }
            for (int i = 0; i < text.Count + 2; i++)
                ans += symbol;
            return ans;
        }
    }
}

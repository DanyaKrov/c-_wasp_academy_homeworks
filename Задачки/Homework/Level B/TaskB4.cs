using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            int check1 = 0, check2 = 0, check3 = 0;
            foreach(char i in s)
            {
                if (String.Equals(i, "("))
                    check1++;
                if (String.Equals(i, ")"))
                    check1--;
                if (String.Equals(i, "{"))
                    check2++;
                if (String.Equals(i, "}"))
                    check2--;
                if (String.Equals(i, "<"))
                    check3++;
                if (String.Equals(i, ">"))
                    check3--;
            }
            return (check1 == 0 && check2 == 0 && check3 == 0);
        }
    }
}

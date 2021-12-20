using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2._1
{
    class Logic
    {
        public static string MultiplicationOfMinimumValues(int a, int b, int c)
        {

            int max;
            double p;
            if ((a == b) && (a == c))
            {
                return "Ошибка! Все три числа не должны быть одинаковыми!";
            }
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if ((a == 0) && (a == max))
            {
                p = b * c;
            }
            if ((b == 0) && (b == max))
            {
                p = a * c;
            }
            if ((c == 0) && (c == max))
            {
                p = b * a;
            }
            else
                p = (a * b * c) / max;
            return "Произведения двух наименьших из трех различных чисел = " + p;

        }
    }
}

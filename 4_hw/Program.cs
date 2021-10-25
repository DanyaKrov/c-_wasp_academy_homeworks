using System;
using System.Collections.Generic;

namespace its_just_start
{
    class Program
    {
        static int[] input_mas(int n) //ввод 1 массива, который  состоит из intю
        {
            int[] mas1 = new int[n];
            int a, number = 0;
            string sa;
            do
            {
                sa = Console.ReadLine();
                if (int.TryParse(sa, out a))
                {
                    mas1[number] = Convert.ToInt32(sa);
                    number += 1;
                }
                else
                    Console.WriteLine("So sorry, wrong type. Enter integer please");
            } while (number < n);
            return mas1;
        }
        static int[,] input_mas_mas(int a, int b) //ввод 1 массива, который  состоит из intю
        {
            int[,] mas2 = new int[a, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    mas2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return mas2;
        }
        static int min_in_mas(int[] mas) //минимум
        {
            int min = 2147483647;
            foreach (int i in mas)
                if (min > i)
                    min = i;
            return min;
        }
        static int max_in_mas(int[] mas) //максимум
        {
            int max = -2147483648;
            foreach (int i in mas)
                if (max < i)
                    max = i;
            return max;
        }
        static int min_in_masm(int[,] mas) //минимум
        {
            int min = 2147483647;
            foreach (int i in mas)
                if (min > i)
                    min = i;
            return min;
        }
        static int max_in_masm(int[,] mas) //максимум
        {
            int max = -2147483648;
            foreach (int i in mas)
                if (max < i)
                    max = i;
            return max;
        }
        static int[] func4(int a, int b, int c, int d) //максимум
        {
            int[] ans = new int[] { Math.Min(a, c), Math.Min(b, d)};
            return ans;
        }
        static int[] sum1(int[] mas1, int[] mas2, int n) //суммирование одномерных массивов
        {
            int[] mas = new int[n];
            int number = 0;
            do
            {
                mas1[number] = mas1[number] + mas2[number];
                number++;
            } while (number < n);
            return mas;
        }
        static int[] sub1(int[] mas1, int[] mas2, int n) //вычитание одномерных массивов
        {
            int[] mas = new int[n];
            int number = 0;
            do
            {
                mas1[number] = mas1[number] - mas2[number];
                number++;
            } while (number < n);
            return mas;
        }
        static int per(int[] mas1, int[] mas2, int n) //вычитание одномерных массивов
        {
            int kol1 = 0;
            int number = 0;
            do
            {
                if (mas1[number] == mas2[number])
                    kol1++;
                number++;
            } while (number < n);
            return kol1 / n * 100;
        }
        static int aver(int[] mas1, int[] mas2, int n) //вычитание одномерных массивов
        {
            int kol1 = 0;
            int number = 0;
            do
            {
                kol1 += mas1[number];
                kol1 += mas2[number];
                number++;
            } while (number < n);
            return kol1 / (n * 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ввод и вывод 1 массива:");
            int n = Convert.ToInt32(Console.ReadLine()); // вводится длина одномерного массива
            int[] mas1 = input_mas(n);
            foreach (int i in mas1)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("ввод и вывод массива массивов:");
            int len2 = Convert.ToInt32(Console.ReadLine()); // вводится длина массивов
            int len3 = Convert.ToInt32(Console.ReadLine()); // вводится количество массивов
            int[,] mas2 = input_mas_mas(len2, len3);
            for (int i = 0; i < len3; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();

            }
            Console.WriteLine($"Минимум массива:{min_in_mas(mas1)} Максимум:{max_in_mas(mas1)}");
            Console.WriteLine($"Минимум массива массивов:{min_in_masm(mas2)} Максимум:{max_in_masm(mas2)}");
            int len = Convert.ToInt32(Console.ReadLine()); // вводится длина нового одномерного массива
            int[] mas3 = input_mas(len); //новый одномерный массив
            int[,] mas4 = new int[4, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }}; //новый двумерный массив
            Console.WriteLine($"Подмассив: {func4(1, n, mas4.Length, 5)}");
            int len4 = Convert.ToInt32(Console.ReadLine()); // вводится длина одномерных массивов для задания 5
            int[] mas5 = input_mas(len4); int[] mas6 = input_mas(len4);
            Console.WriteLine("Суммированный массив:");
            int[] mas7 = sum1(mas5, mas6, len4);
            int[] mas8 = sub1(mas5, mas6, len4);
            int number = 0;
            do
            {
                Console.Write(mas7[number] + " ");
                number++;
            } while (number < n);
            Console.WriteLine("Вычитанный массив:");
            number = 0;
            do
            {
                Console.Write(mas8[number] + " ");
                number++;
            } while (number < n);
            Console.WriteLine();
            Console.WriteLine($"Процент совпадения массивов:{per(mas5, mas6, len4)}");
            Console.WriteLine($"Среднее значение массивов:{aver(mas5, mas6, len4)}");
        }
    }
}
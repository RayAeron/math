﻿using System;

namespace ConsoleApplication11
{
    class math
    {
        struct Element
        {
            public int Delivery { get; set; }
            public int Value { get; set; }
            public static int FindMinElement(int a, int b)
            {
                if (a > b) return b;
                if (a == b) { return a; }
                else return a;
            }


            static void Main(string[] args)
            {
                int i = 0;
                int j = 0;
                int n;

                Console.WriteLine("Введите количество A");
                n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];

                Console.WriteLine("Введите количество B");
                int m = Convert.ToInt32(Console.ReadLine());
                int[] b = new int[m];
                Element[,] C = new Element[n, m];

                Console.WriteLine("Введите a[i]");
                for (i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите b[i]");
                for (j = 0; j < b.Length; j++)
                {
                    b[j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();

                Console.WriteLine("Введите C[i][j]");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        Console.Write("a[{0},{1}] = ", i, j);
                        C[i, j].Value = Convert.ToInt32(Console.ReadLine());
                    }
                }
                i = j = 0;

                while (i < n && j < m)
                {
                    try
                    {
                        if (a[i] == 0) { i++; }
                        if (b[j] == 0) { j++; }
                        if (a[i] == 0 && b[j] == 0) { i++; j++; }
                        C[i, j].Delivery = Element.FindMinElement(a[i], b[j]);
                        a[i] -= C[i, j].Delivery;
                        b[j] -= C[i, j].Delivery;
                    }
                    catch { }
                }
                Console.Clear();


                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        if (C[i, j].Delivery != 0)
                        {

                            Console.Write("({0})", C[i, j].Delivery);
                        }
                        else
                            Console.Write("(0)", C[i, j].Delivery);
                    }
                    Console.WriteLine();
                }

                int ResultFunction = 0;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        ResultFunction += (C[i, j].Value * C[i, j].Delivery);
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Результат = {0}", ResultFunction);
                i = 0;
                j = 0;
                int[] u = new int[n];
                int[] v = new int[m];
                Console.ReadLine();
            }
        }
    }
}
using System;

namespace HOMEWORK_5
{
    class Program
    {
        static void Main(string[] args)
       {
            int sum = 0;
            #region 1 
            {
                for (int i = 0; i < 50; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            #endregion 
            #region 2
            {
                sum = 0;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                for (int i = a; i < b; i++)
                {
                    if (i % 4 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region 3(a)
            for (int i = 10; i < 100; i++)
            {
                if (((i / 10) * (i / 10) + (i % 10) * (i % 10)) % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region 3(b)
            for (int i = 10; i < 100; i++)
            {
                if ((i / 10 + i % 10) + (i / 10 + i % 10) * (i / 10 + i % 10) == i)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region 4
            {
                //4(А)
                double u;
                double[] f = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
                u = f[0];
                foreach (double i in f)
                {
                    u = Math.Max(u, i);
                }
                Console.WriteLine(u);
                //4(Б)
                double[] o = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
                u = o[0];
                foreach (double i in o)
                {
                    u = Math.Min(u, i);
                }
                Console.WriteLine(u);
                //4(В)
                double[] p = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
                double y = p[0];
                u = y;
                foreach (double i in p)
                {
                    u = Math.Max(u, i);
                    y = Math.Min(y, i);
                }
                Console.WriteLine(u);
                Console.WriteLine(y);
            }
            #endregion
            #region 5
            {
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                sum = 0;
                int C = 1;
                for (int i = A; i <= B; i++)
                {
                    sum += i;
                    C *= i;
                }
                Console.WriteLine(sum);
                Console.WriteLine(C);
            }
            #endregion
            #region 6
            {
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                int num = 0;
                for (int i = A; i <= B; i++)
                {
                    num++;
                    Console.WriteLine(i);
                }
                Console.WriteLine(num);
            }
            #endregion
            #region 7
            {
                double cost = double.Parse(Console.ReadLine());
                for (decimal i = 1.2m; i <= 2; i += 0.2m)
                {
                    Console.WriteLine(i + ": " + (decimal)cost * i);
                }
            }
            #endregion
            #region 8
            {
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            #endregion
        }
    }
}

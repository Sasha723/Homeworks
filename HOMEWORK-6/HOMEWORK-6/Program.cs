using System;

namespace HOMEWORK_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            {
                char[] arr = new char[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = char.Parse(Console.ReadLine());
                }
                foreach (char i in arr)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
            }
            #endregion
            #region 2
            {
                //2(а)
                double[] arr = new double[15];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("\n");
                //2(б)
                double[] arr1 = new double[15];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = 22 + new Random().NextDouble();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("\n");
                //2(в)
                double[] arr2 = new double[15];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 10) + new Random().NextDouble();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("\n");
                //2(г)
                double[] arr3 = new double[15];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-50, 50) + new Random().NextDouble();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("\n");
                //2(д)
                double[] arr4 = new double[15];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 11);
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("\n");
            }
            #endregion
            #region 4
            {
                //4(а)
                double[] arr = new double[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 100);
                    Console.Write(arr[i] + "\t");
                    arr[i] *= 2;
                    Console.WriteLine(arr[i]);
                }
                //4(б)
                double[] arr2 = new double[10];
                double A = double.Parse(Console.ReadLine());
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = new Random().Next(1, 100);
                    Console.Write(arr2[i] + "\t");
                    arr2[i] -= A;
                    Console.WriteLine(arr2[i]);
                }
                //4(в)
                double[] arr3 = new double[10];
                arr3[0] = new Random().Next(1, 100);
                Console.Write(arr3[0] + "\t");
                Console.WriteLine(1);
                for (int i = 1; i < arr3.Length; i++)
                {
                    arr3[i] = new Random().Next(1, 100);
                    Console.Write(arr3[i] + "\t");
                    arr3[i] /= arr3[0];
                    Console.WriteLine(arr3[i]);
                }
            }
            #endregion
            #region 5
            {
                double[] arr = new double[12];
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 100);
                    sum += arr[i];
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region 6
            {
                double[] arr = new double[12];
                double sum = 0;
                double sum2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 100);
                    sum += arr[i];
                    sum2 += arr[i] * arr[i];
                }
                Console.WriteLine(sum);
                Console.WriteLine("сумма элементов массива есть четное число: " + (sum % 2 == 0));
                Console.WriteLine(sum2);
                Console.WriteLine("сумма элементов массива есть четное число: " + ((sum2 / 10000) >= 1));
            }
            #endregion
            #region 7
            {
                double[] arr = new double[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 1000);
                    Console.Write(arr[i] + "\t");
                    if (arr[i] > 0)
                    {
                        Console.Write(arr[i] + "\t");
                    }
                    if (arr[i] <= 100)
                    {
                        Console.Write(arr[i]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region 8
            {
                double[] arr = new double[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 1000);
                    Console.Write(arr[i] + "\t");
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + "\t");
                    }
                    if (arr[i] % 10 == 0)
                    {
                        Console.Write(arr[i]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region 9
            {
                double[] arr = new double[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                foreach (double i in arr)
                {
                    if (i > 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine();
                foreach (double i in arr)
                {
                    if (i < 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            #endregion
            #region 10
            {
                double[] arr = new double[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.Write(i + ": ");
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                for (int i = 2; i < arr.Length; i += 2)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            #endregion
            #region 11
            {
                double[] arr = new double[10];
                double sum = 0;
                double a = double.Parse(Console.ReadLine());
                double sum2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 100);
                    Console.WriteLine(arr[i]);
                    if (arr[i] <= 20)
                    {
                        sum += arr[i];
                    }
                    if (arr[i] > a)
                    {
                        sum2 += arr[i];
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine(sum2);
            }
            #endregion
            #region 12
            {
                double[] arr = new double[10];
                double sum = 0;
                double a = double.Parse(Console.ReadLine());
                double sum2 = 0;
                double b = double.Parse(Console.ReadLine());
                double sum3 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 100);
                    Console.WriteLine(arr[i]);
                    if (arr[i] % 2 != 0)
                    {
                        sum += arr[i];
                    }
                    if (arr[i] % a == 0)
                    {
                        sum2 += arr[i];
                    }
                    if ((arr[i] % a == 0) & (arr[i] % b == 0))
                    {
                        sum3 += arr[i];
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine(sum2);
                Console.WriteLine(sum3);
            }
            #endregion
            #region 13
            {
                double[] arr = new double[10];
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 100);
                    Console.WriteLine(arr[i]);
                    if (i != 0 & i % 2 == 0)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region 14
            {
                double[] arr = new double[10];
                double count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.WriteLine(arr[i]);
                    if (arr[i] >= 0)
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(count);
            }
            #endregion
            #region 15
            {
                double[] arr = new double[22];
                double r = double.Parse(Console.ReadLine());
                double count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(50, 180);
                    Console.WriteLine(arr[i]);
                    if (arr[i] <= r)
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(count);
            }
            #endregion
        }
    }
}

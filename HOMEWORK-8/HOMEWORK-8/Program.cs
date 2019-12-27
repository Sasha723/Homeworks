using System;

namespace HOMEWORK_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            {
                int maxi;
                int maxj;
                int max;
                int num1 = 6;
                int num2 = 5;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                max = arr[0, 0];
                maxi = 0;
                maxj = 0;
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        if (max < arr[i, j])
                        {
                            max = arr[i, j];
                            maxi = i;
                            maxj = j;
                        }
                    }
                }
                Console.WriteLine(max + " [" + maxi + ", " + maxj + "]  ");
            }
            #endregion
            #region 2
            {
                int n = int.Parse(Console.ReadLine());
                string[,] arr = new string[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = ".";
                        if (i == j || n - j - 1 == i || j == n / 2 || i == n / 2)
                        {
                            arr[i, j] = "*";
                        }
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region 3
            {
                int temp;
                int num = 5;
                int num1i = 0;
                int num1j = 0;
                int num2i = 0;
                int num2j = num;
                int[,] arr = new int[num, num];
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (i == j)
                        {
                            num1i = i;
                            num1j = j;
                        }
                        if (j == num - i - 1)
                        {
                            num2i = i;
                            num2j = j;
                        }
                    }
                    temp = arr[num1j, num1i];
                    arr[num1j, num1i] = arr[num2j, num2i];
                    arr[num2j, num2i] = temp;
                }

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            } 
            #endregion
            #region 4
            {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] arr = new int[n, m];
                int[,] arr2 = new int[m, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
                for (int i = 0; i < m; i++)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        arr2[i, j] = arr[j, i];
                        Console.Write(arr2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}


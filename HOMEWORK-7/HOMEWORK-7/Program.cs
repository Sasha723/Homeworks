using System;

namespace HOMEWORK_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            {
                int num1 = 5;
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
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        if (i == 1)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region 2
            {
                int[] arr = new int[5];
                int[] arr2 = new int[5];
                int[] sum = new int[5];
                int[] sum2 = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 10);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = new Random().Next(1, 10);
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = arr[i] + arr2[i];
                    Console.Write(sum[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < sum2.Length; i++)
                {
                    sum2[i] = arr[i] * arr2[i];
                    Console.Write(sum2[i] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            #region 3
            {
                int[] arr = new int[5];
                bool b = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 10);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = arr.Length - 1; j >= i + 1; j--)
                    {
                        if (arr[i] == arr[j])
                        {
                            Console.Write(arr[i] + " ");
                            b = true;
                        }
                    }
                }
                Console.WriteLine();
                if (b == false)
                {
                    Console.WriteLine(b);
                }
            }
            #endregion
            #region 4
            {
                int[] arr = new int[5];
                int a = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 10);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = arr.Length - 1; j >= i + 1; j--)
                    {
                        if (arr[i] == arr[j])
                        {
                            a -= 1;
                        }
                    }
                }
                Console.WriteLine(a);
            }
            #endregion
            #region 5
            {
                int num1 = 5;
                int num2 = 6;
                int a = 0;
                int a1 = num2;
                int b = 0;
                int b1 = num1;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(-5, 10);
                        Console.Write(arr[i, j] + "\t");
                        if (arr[i, j] >= 0)
                        {
                            a1 -= 1;
                            if (a1 == 0)
                            {
                                a += 1;
                            }
                        }
                    }
                    a1 = num2;
                    Console.WriteLine();
                }
                Console.WriteLine(a);
                for (int i = 0; i < num2; i++)
                {
                    for (int j = 0; j < num1; j++)
                    {
                        if (arr[j, i] >= 0)
                        {
                            b1 -= 1;
                            if (b1 == 0)
                            {
                                b += 1;
                            }
                        }
                    }
                    b1 = num1;
                }
                Console.WriteLine(b);
            }
            #endregion
            #region 6
            {
                int temp;
                int sum1 = 0;
                int sum2 = 0;
                int num1 = 3;
                int num2 = 4;
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
                Console.WriteLine();
                for (int k = 0; k < num2; k++)
                {
                    for (int i = 0; i < num2 - 1; i++)
                    {
                        for (int j = 0; j < num1; j++)
                        {
                            sum1 += arr[j, i];
                            sum2 += arr[j, i + 1];
                        }
                        if (sum1 > sum2)
                        {
                            for (int j = 0; j < num1; j++)
                            {
                                temp = arr[j, i];
                                arr[j, i] = arr[j, i + 1];
                                arr[j, i + 1] = temp;
                            }
                        }
                        sum1 = 0;
                        sum2 = 0;
                    } 
                }
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region 7
            {
                int sum = 0;
                int num1 = 5;
                int num2 = 5;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                        sum += arr[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region 8
            {
                int num1 = 9;
                int num2 = 9;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                        if (i == j || num2 - 1 - j == i)
                        {
                            arr[i, j] = 0;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region 9
            {
                int num = 0;
                int num1 = 6;
                int num2 = 5;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(-10, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        num += 1;
                        if (arr[i, j] < 0)
                        {
                            Console.Write(num + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
            #endregion
            #region 10
            {
                int temp;
                int max;
                int min;
                int maxi = 0;
                int maxj = 0;
                int mini = 0;
                int minj = 0;
                int num1 = 6;
                int num2 = 5;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(0, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                max = arr[0, 0];
                min = arr[0, 0];
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
                        if (min > arr[i, j])
                        {
                            min = arr[i, j];
                            mini = i;
                            minj = j;
                        }
                    }
                }
                temp = arr[mini, minj];
                arr[mini, minj] = arr[maxi, maxj];
                arr[maxi, maxj] = temp;
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region 11
            {
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                int num1 = 6;
                int num2 = 5;
                int[,] arr = new int[num1, num2];
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        arr[i, j] = new Random().Next(0, 10);
                        Console.Write(arr[i, j] + " ");
                        if (arr[i, j] > num)
                        {
                            sum += arr[i, j];
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(sum);
            }
            #endregion
        }
    }
}

using System;

namespace HOMEWORK_6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[20];
            double a;
            bool b = false;
            for (int i = 0; i < arr.Length; i++)
            {
                b = false;
                a = new Random().Next(1, 21);
                for (int j = 0; j < i + 1; j++)
                {
                    if (a == arr[j])
                    {
                        i -= 1;
                        b = true;
                        break;
                    }
                }
                if (b == true)
                {
                    continue;
                }
                arr[i] = a;
                
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

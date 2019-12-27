using System;

namespace HOMEWORK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            double A;
            double B;
            double C;
            double D;
            double E;
            double F;
            string k;
            //1
            Console.Write("Input a number: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                a++;
            }
            if (a < 0)
            {
                a -= 2;
            }
            if (a == 0)
            {
                a = 10;
            }
            Console.WriteLine(a);
            //2
            Console.Write("Input the first numbers: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input the second numbers: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input the third numbers: ");
            c = int.Parse(Console.ReadLine());
            d = 0;
            if (a > 0)
            {
                d += 1;
            }
            if (b > 0)
            {
                d += 1;
            }
            if (c > 0)
            {
                d += 1;
            }
            Console.WriteLine(d);
            //3
            Console.Write("Input the first numbers: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input the second numbers: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input the third numbers: ");
            c = int.Parse(Console.ReadLine());
            d = 0;
            e = 0;
            if (a > 0)
            {
                d += 1;
            }
            else if (a < 0) e += 1;
            if (b > 0)
            {
                d += 1;
            }
            else if (b < 0) e += 1;
            if (c > 0)
            {
                d += 1;
            }
            else if (c < 0) e += 1;
            Console.WriteLine(d);
            Console.WriteLine(e);
            //4
            Console.Write("Input the first numbers: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input the second numbers: ");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                a = 0;
                b = 0;
            }
            else
            {
                a += b;
                b = a;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            //5
            Console.Write("Input the first numbers: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine(A % 2 == 0 ? true : false);
            //6
            A = 0.1;
            B = 1000;
            C = 1;
            D = 0.001;
            E = 0.01;
            F = double.Parse(Console.ReadLine());
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    C = A * F;
                    Console.WriteLine(C);
                    break;
                case 2:
                    C = B * F;
                    Console.WriteLine(C);
                    break;
                case 3:
                    C = F;
                    Console.WriteLine(C);
                    break;
                case 4:
                    C = D * F;
                    Console.WriteLine(C);
                    break;
                case 5:
                    C = E * F;
                    Console.WriteLine(C);
                    break;
            }
            //7
            k = Console.ReadLine();
            switch (k)
            {

                case "С":
                    switch (Console.ReadLine())
                    {
                        case "1":
                            k = "З";
                            break;
                        case "-1":
                            k = "В";
                            break;
                    }
                    break;
                case "Ю":
                    switch (Console.ReadLine())
                    {
                        case "1":
                            k = "В";
                            break;
                        case "-1":
                            k = "З";
                            break;
                    }
                    break;
                case "З":
                    switch (Console.ReadLine())
                    {
                        case "1":
                            k = "Ю";
                            break;
                        case "-1":
                            k = "С";
                            break;
                    }
                    break;
                case "В":
                    switch (Console.ReadLine())
                    {
                        case "1":
                            k = "С";
                            break;
                        case "-1":
                            k = "Ю";
                            break;
                    }
                    break;
            }
            Console.WriteLine(k);
            //8
            a = new Random().Next(20, 69);
            if (a % 10 == 1)
            {
                Console.WriteLine(a + " год");
            }
            else if (a % 10 > 1 & a % 10 < 5)
            {
                Console.WriteLine(a + " года");
            }
            else
            {
                Console.WriteLine(a + " лет");
            }


        }
    }
}

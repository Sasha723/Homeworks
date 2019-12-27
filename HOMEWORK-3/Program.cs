using System;

namespace HOMEWORK_3
{
    class Program
    {
        static void eur(double gryvna)
        {
            double euro = gryvna * 0.04;
            Console.WriteLine(euro);
        }
        static void dol(double gryvna)
        {
            double dollar = gryvna * 0.04;
            Console.WriteLine(dollar);
        }
        static void rub(double gryvna)
        {
            double rubly = gryvna * 2.54;
            Console.WriteLine(rubly);
        }
        static void minutes(double seconds)
        {
            double minutss = seconds / 60;
            Console.WriteLine(minutss);
        }
        static void hours(double seconds)
        {
            double hourss = seconds / 3600;
            Console.WriteLine(hourss);
        }
        static void days(double seconds)
        {
            double dayss = seconds / 86400;
            Console.WriteLine(dayss);
        }
        static void square(double santimeters)
        {
            double perimetr = santimeters * 4;
            Console.WriteLine(perimetr);
        }
        static void diametr(double radius)
        {
            double diametrs = radius * 2;
            Console.WriteLine(diametrs);
        }
        static double skidkaa(double sum, double skidka)
        {
            double SummaSkidki = sum / 100 * skidka;
            return SummaSkidki;
        }
        static void summa(double sum, double SummaSkidki)
        {
            double SummaWithSkidka = sum - SummaSkidki;
            Console.WriteLine(SummaWithSkidka);
        }
        static void Main(string[] args)
        {
            //1
            Console.Write("Input a number: ");
            try
            {
                double gryvna = Double.Parse(Console.ReadLine());
                dol(gryvna);
                eur(gryvna);
                rub(gryvna);
            }
            catch
            {
                Console.Write("Try again: ");
                double gryvna = Double.Parse(Console.ReadLine());
                dol(gryvna);
                eur(gryvna);
                rub(gryvna);
            }
            //2
            Console.Write("Input a number: ");
            try
            {
                double seconds = Double.Parse(Console.ReadLine());
                minutes(seconds);
                hours(seconds);
                days(seconds);
            }
            catch
            {
                Console.Write("Try again: ");
                double seconds = Double.Parse(Console.ReadLine());
                minutes(seconds);
                hours(seconds);
                days(seconds);
            }
            //3
            Console.Write("Input a number: ");
            try
            {
                double santimeters = Double.Parse(Console.ReadLine());
                square(santimeters);
            }
            catch
            {
                Console.Write("Try again: ");
                double santimeters = Double.Parse(Console.ReadLine());
                square(santimeters);
            }
            //4
            Console.Write("Input a number: ");
            try
            {
                double radius = Double.Parse(Console.ReadLine());
                diametr(radius);
            }
            catch
            {
                Console.Write("Try again: ");
                double radius = Double.Parse(Console.ReadLine());
                diametr(radius);

            }
            //5
            Console.Write("Введите сумму покупки: ");
            try
            {
                double sum = Double.Parse(Console.ReadLine());
                Console.Write("Введите свою скидку: ");
                double skidka = Double.Parse(Console.ReadLine());
                double SumSkidki = skidkaa(sum, skidka);
                summa(sum, SumSkidki);
            }
            catch
            {
                Console.Write("Try again: ");
                double sum = Double.Parse(Console.ReadLine());
                Console.Write("And: ");
                double skidka = Double.Parse(Console.ReadLine());
                double SumSkidki = skidkaa(sum, skidka);
                summa(sum, SumSkidki);
            }
        }


    }
}


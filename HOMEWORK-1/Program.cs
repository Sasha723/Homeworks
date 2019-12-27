using System;

namespace HOMEWORK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void years()
            {
                Console.WriteLine("Enter years please");
                string Earth = Console.ReadLine();
                int Earthyear = Int32.Parse(Earth);
                var seconds = 31557600;
                var Merkuriys = 0.2408467;
                double Merkuriy = seconds * Earthyear / (seconds * Merkuriys);
                var Veneras = 0.61519726;
                double Venera = seconds * Earthyear / (seconds * Veneras);
                var Marss = 1.8808158;
                double Mars = seconds * Earthyear / (seconds * Marss);
                var Yupiters = 11.862615;
                double Yupiter = seconds * Earthyear / (seconds * Yupiters);
                var Saturns = 29.447498;
                double Saturn = seconds * Earthyear / (seconds * Saturns);
                var Urans = 84.016846;
                double Uran = seconds * Earthyear / (seconds * Urans);
                var Neptuns = 164.79132;
                double Neptun = seconds * Earthyear / (seconds * Neptuns);
                Console.WriteLine($"На Земле тебе {Earth};" + $" На меркурии тебе {Merkuriy};" + $" На Венере тебе {Venera};" + $" На марсе тебе {Mars};" + $" На Юпитере тебе {Yupiter};" + $" На Сатурне тебе {Saturn};" + $" На Уране тебе {Uran};" + $" На Нептуне тебе {Neptun}");
                years();
            }
            years();



        }
    }
}

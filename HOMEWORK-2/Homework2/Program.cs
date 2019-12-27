using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            Console.WriteLine("Число пи равно " + Math.PI);
            Console.WriteLine("Число пи равно {0}", Math.PI);
            Console.WriteLine($"Число пи равно {Math.PI}");
            Console.Write("Число пи равно " + Math.PI);
            Console.WriteLine(" ");
            Console.ReadKey();
            //Задание №2
            Console.Write("Какое ваше имя? ");
            string FirstName = Console.ReadLine();
            Console.Write("Какая ваша фамилия? ");
            string SecondName = Console.ReadLine();
            Console.Write("Какое ваше отчество? ");
            string ThirdName = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            byte YearsOfPerson = Byte.Parse(Console.ReadLine());
            Console.Write("В каком году вы родились? ");
            int BirthDay = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} {1} {2}", FirstName, SecondName, ThirdName);
            Console.WriteLine("Вы роделись в " + BirthDay + " году");
            Console.WriteLine("Вам " + YearsOfPerson + " лет");
            Console.ReadKey();
            //Задание №3
            Console.WriteLine("Операционная система (номер версии):  {0}", Environment.OSVersion);
            Console.WriteLine("Разрядность процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            Console.WriteLine("Модель процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            Console.WriteLine("Число процессоров:  {0}", Environment.ProcessorCount);
            Console.WriteLine("Имя пользователя: {0}", Environment.UserName);
            Console.WriteLine("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            Console.ReadKey();
            //Задание №4
            Console.Write("Введите первую переменную: ");
            string first = Console.ReadLine();
            Console.Write("Введите вторую переменную: ");
            string second = Console.ReadLine();
            string third = first;
            first = second;
            Console.WriteLine($"{first}, {third}");
            Console.ReadKey();
            //Задание №5
            Console.Write("Введиту расстояние в сантиметрах: ");
            int santimeters = Int32.Parse(Console.ReadLine());
            Console.WriteLine(santimeters + " сантиметров — это " + santimeters / 100 + " метров");
            Console.ReadKey();
            //Задание №6
            Console.WriteLine("Прошло " + 234 / 7 + " недели");
            Console.ReadKey();
            //Задание №7
            Console.WriteLine("Можно отрезать " + 543 * 130 / (130 * 130) + " квадрата");
            Console.ReadKey();
            //Задание №8
            Console.Write("Введите трёхзначное число: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number / 10 % 10);
            Console.WriteLine(number % 10);
            Console.WriteLine(number / 100 % 10 + number / 10 % 10 + number % 10);
            Console.WriteLine((number / 100 % 10) * (number / 10 % 10) * (number % 10));
            Console.ReadKey();
            //Задание №9
            Console.Write("Введите первое число: ");
            float first1 = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float second1 = float.Parse(Console.ReadLine());
            Console.WriteLine((first1 + second1) / 2);
            Console.ReadKey();
            //Задание №10
            Console.Write("Введите число: ");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(number1, 2));
            Console.ReadKey();
            //Задание №11
            Console.Write("Введите трёхзначное число: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine((number2 % 10) + "" + (number2 / 10 % 10) + "" + (number2 / 100 % 10));
            Console.ReadKey();
            //Задание №12
            Console.Write("Введите трёхзначное число: ");
            int number3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine((number3 / 10 % 10) + "" + (number3 / 100 % 10) + "" + (number3 % 10));
            Console.ReadKey();
        }
    }
}

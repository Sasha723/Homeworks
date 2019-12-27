using System;
using System.Collections.Generic;

namespace HOMEWORK_11
{
    class Arrays
    {
        private int[,] arr;
        private int[,] arrr;
        public Arrays(int arr1, int arr2)
        {
            Input(arr1, arr2);
            Output(arr1, arr2);
        }
        public int[,] Input(int arr1, int arr2)
        {
            arr = new int[arr1, arr2];
            for (int i = 0; i < arr1; i++)
            {
                for (int j = 0; j < arr2; j++)
                {
                    arr[i, j] = new Random().Next(1, 100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arr;
        }
        public void Output(int arr1, int arr2)
        {
            arrr = new int[arr2, arr1];
            for (int i = 0; i < arr2; i++)
            {
                for (int j = 0; j < arr1; j++)
                {
                    arrr[i, j] = arr[j, i];
                    Console.Write(arrr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Children
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
    class Titles
    {
        public string brand;
        public double size_h;
        public double size_w;
        public double price;
        public void getData()
        {
            Console.WriteLine(brand);
            Console.WriteLine(size_h);
            Console.WriteLine(size_w);
            Console.WriteLine(price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Titles titles = new Titles();
            //titles.brand = "Title";
            //titles.size_h = 0.5;
            //titles.size_w = 0.5;
            //titles.price = 175;
            //titles.getData();
            //Children children1 = new Children();
            //children1.FirstName = "Ivan";
            //children1.SecondName = "Ivanov";
            //children1.Age = 15;
            //Children children2 = new Children();
            //children2.FirstName = "Petr";
            //children2.SecondName = "Petrenko";
            //children2.Age = 14;
            //Console.WriteLine(children1.SecondName + " " + children1.FirstName + " " + children1.Age);
            //Console.WriteLine(children2.SecondName + " " + children2.FirstName + " " + children2.Age);
            Arrays arrays = new Arrays(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

        }
    } 
}

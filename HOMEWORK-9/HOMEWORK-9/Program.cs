using System;
using System.Text;

namespace HOMEWORK_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Составить программу обмена значениями трех переменных величин а, b, c строкового типа по следующей схеме
            {
                #region b присвоить значение c, а присвоить значение b, c присвоить значение а
                {
                    string a = "Hello";
                    string b = "World";
                    string c = "Word";
                    string temp;
                    temp = c;
                    c = a;
                    a = b;
                    b = temp;
                    Console.WriteLine(a + " " + b + " " + c);
                }
                #endregion
                #region b присвоить значение а, с присвоить значение b, а присвоить значение c​
                {
                    string a = "Hello";
                    string b = "World";
                    string c = "Word";
                    string temp;
                    temp = a;
                    a = c;
                    c = b;
                    b = temp;
                    Console.WriteLine(a + " " + b + " " + c);
                }
                #endregion
            }
            #endregion
            #region Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же  букву?​
            {
                string str = Console.ReadLine();
                Console.WriteLine(str[0] == str[str.Length - 1]);
            }
            #endregion
            #region Даны два слова. Верно ли, что первое слово начинается на ту же букву, на которую заканчивается второе слово? ​
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                Console.WriteLine(str1[0] == str2[str2.Length - 1]);
            }
            #endregion
            #region Дано предложение. Определить, сколько в нем одинаковых пар соседних букв.​
            {
                string str = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = str.Length - 1; j >= i + 2; j--)
                    {
                        if (str[i] == str[j - 1] && str[i + 1] == str[j])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
            #endregion
            #region Дан текст. Определить, сколько в нем предложений. ​
            {
                string str = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.' || str[i] == '?' || str[i] == '!')
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            #endregion
            #region Дано предложение, в котором имеются одна буква с и одна буква Т. Определить, какая из них встречается раньше (при просмотре слова слева направо)​
            {
                string str = Console.ReadLine();
                if (str.IndexOf('c') != -1 && str.IndexOf('T') != -1)
                {
                    if (str.IndexOf('c') < str.IndexOf('T'))
                    {
                        Console.WriteLine("c");
                    }
                    else if (str.IndexOf('c') > str.IndexOf('T'))
                    {
                        Console.WriteLine("T");
                    }
                }
            }
            #endregion
            #region Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой а. ​
            {
                StringBuilder str = new StringBuilder(Console.ReadLine());
                for (int i = 0; i < str.Length; i++)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        str[i] = 'a';
                    }
                }
                Console.WriteLine(str);
            }
            #endregion
            #region Дано слово. Поменять местами его вторую и пятую буквы.
            {
                StringBuilder str = new StringBuilder(Console.ReadLine());
                char temp = str[1];
                str[1] = str[4];
                str[4] = temp;
                Console.WriteLine(str);
            }
            #endregion
            #region Дан текст. Найти сумму всех имеющихся в нем чисел.​
            {
                string str = Console.ReadLine();
                int sum = 0;
                string numbers = "1234567890";
                for (int i = 0; i < str.Length; i++)
                {
                    if (numbers.Contains(str[i]))
                    {
                        sum += int.Parse(str[i].ToString());
                    }
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region *Дано натуральное число n (n  1000). Напечатать это число русскими словами (тринадцать, сто пять, двести сорок один, тысяча и т. д.). ​
            {
                int n = int.Parse(Console.ReadLine());
                if (n / 1000 % 10 == 1)
                {
                    Console.Write("тысяча ");
                }
                if (n / 100 % 10 == 1)
                {
                    Console.Write("сто ");
                }
                else if (n / 100 % 10 == 2)
                {
                    Console.Write("двести ");
                }
                else if (n / 100 % 10 == 3)
                {
                    Console.Write("триста ");
                }
                else if (n / 100 % 10 == 4)
                {
                    Console.Write("четиреста ");
                }
                else if (n / 100 % 10 == 5)
                {
                    Console.Write("пятсот ");
                }
                else if (n / 100 % 10 == 6)
                {
                    Console.Write("шестсот ");
                }
                else if (n / 100 % 10 == 7)
                {
                    Console.Write("семсот ");
                }
                else if (n / 100 % 10 == 8)
                {
                    Console.Write("восемьсот ");
                }
                else if (n / 100 % 10 == 9)
                {
                    Console.Write("девятсот ");
                }
                if (n / 10 % 10 == 1 && n % 10 == 0)
                {
                    Console.WriteLine("десять");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 1)
                {
                    Console.WriteLine("одинадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 2)
                {
                    Console.WriteLine("двенадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 3)
                {
                    Console.WriteLine("тринадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 4)
                {
                    Console.WriteLine("четырнадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 5)
                {
                    Console.WriteLine("пятнадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 6)
                {
                    Console.WriteLine("шестнадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 7)
                {
                    Console.WriteLine("семнадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 8)
                {
                    Console.WriteLine("восемнадцать");
                }
                else if (n / 10 % 10 == 1 && n % 10 == 9)
                {
                    Console.WriteLine("девятнадцать");
                }
                else if (n / 10 % 10 == 2)
                {
                    Console.Write("двадцать ");
                }
                else if (n / 10 % 10 == 3)
                {
                    Console.Write("тридцать ");
                }
                else if (n / 10 % 10 == 4)
                {
                    Console.Write("сорок ");
                }
                else if (n / 10 % 10 == 5)
                {
                    Console.Write("пятьдесят ");
                }
                else if (n / 10 % 10 == 6)
                {
                    Console.Write("шестьдесят ");
                }
                else if (n / 10 % 10 == 7)
                {
                    Console.Write("семьдесят ");
                }
                else if (n / 10 % 10 == 8)
                {
                    Console.Write("восемьдесят ");
                }
                else if (n / 10 % 10 == 9)
                {
                    Console.Write("девяносто ");
                }
                if (n % 10 == 1 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("один");
                }
                else if (n % 10 == 2 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("два");
                }
                else if (n % 10 == 3 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("три");
                }
                else if (n % 10 == 4 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("четыре");
                }
                else if (n % 10 == 5 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("пять");
                }
                else if (n % 10 == 6 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("шесть");
                }
                else if (n % 10 == 7 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("семь");
                }
                else if (n % 10 == 8 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("восемь");
                }
                else if (n % 10 == 9 && n / 10 % 10 != 1)
                {
                    Console.WriteLine("девять");
                }
            }
            #endregion
        }
    }
}

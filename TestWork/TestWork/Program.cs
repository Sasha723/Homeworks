using System;
using System.Globalization;

namespace TestWork
{
    class Program
    {
        static void Russian()
        {
            string[] words = { "привет", "день", "собака", "линия", "слово", "мир" };
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("                             ПОЛЕ ЧУДЕС");
            Console.WriteLine("\n");
            Console.WriteLine("                 нажмите на любую клавишу чтобы начать");
            Console.ReadKey();
            Console.Clear();
        menu:
            Console.WriteLine("                    МЕНЮ");
            Console.WriteLine("—— Чтобы начать, введите старт");
            Console.WriteLine("—— Чтобы узнать правила, введите правила");
            Console.WriteLine("—— Чтобы поменять язык, введите языки");
            string menu = Console.ReadLine().ToLower();
            Console.Clear();
            if (menu == "старт")
            {
                goto firststart;
            }
            else if (menu == "правила")
            {
                goto rules;
            }
            else if (menu == "языки")
            {
                goto languages;
            }
            else
            {
                goto menu;
            }
        languages:
            Console.WriteLine("                    ЯЗЫКИ");
            Console.WriteLine("—— Чтобы перевести игру на английский, впишите английский");
            Console.WriteLine("—— Чтобы оменить, впишите что угодно");
            string languages = Console.ReadLine().ToLower();
            Console.Clear();
            if (languages == "английский")
            {
                English();
                goto fullfinish;
            }
            else
            {
                goto menu;
            }
        rules:
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("В этой игре тебе надо будет отгадать слово");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("У тебя есть 7 попыток");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("У тебя есть 7 попыток   ] —— Это твои попытки. Попытки заканчиваются —— ТЫ ПРОИГРАЛ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("_ _ _ _ _");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("_ _ _ _ _   ] —— Это твоё слово. Ты должен отгадать его");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("Неверные буквы:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    ПРАВИЛА");
            Console.WriteLine("Неверные буквы:   ] —— Это твои неверные буквы");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Нажмите на любую кнопку чтобы переместиться в меню");
            Console.ReadKey();
            Console.Clear();
            goto menu;
        firststart:
            Console.Clear();
            char ch;
            string b;
            int a = 0;
            string word = words[new Random().Next(0, words.Length)];
            char[] symbols = new char[word.Length];
            char[] print = new char[word.Length];
            int attempts = word.Length + 2;
            char[] wrong = new char[attempts];
            int wrongindex = 0;
        maybestartexception:
            Console.WriteLine("У тебя есть " + attempts + " попыток");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                symbols[i] = word[i];
                print[i] = '_';
                Console.Write(print[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Неверные буквы: ");
        start:
            a += 1;
            Console.Write("Введите символ: ");
            b = Console.ReadLine();
            if (b.Length > 1 || b == "" || b == " ")
            {
                Console.Clear();
                Console.WriteLine("Вы должны ввести только один символ");
                Console.WriteLine("Попробуйте ещё раз");
                Console.ReadKey();
                Console.Clear();
                if (a == 1)
                {
                    goto maybestartexception;
                }
                else
                {
                    goto maybeexception;
                }
            }
            ch = char.Parse(b);
            Console.WriteLine();
            Console.Clear();
            for (int i = 0; i < word.Length; i++)
            {
                if (ch == word[i])
                {
                    print[i] = ch;
                    count += 1;
                }
            }
            if (count == 0)
            {
                wrong[wrongindex] = ch;
                wrongindex += 1;
                attempts -= 1;
                if (attempts == 0)
                {
                    Console.WriteLine("ТЫ ПРОИГРАЛ!!!");
                    goto finish;
                }
            }
        maybeexception:
            Console.WriteLine(attempts + " попыток осталось");
            count = 0;
            foreach (var item in print)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Неверные буквы: ");
            for (int i = 0; i <= wrongindex; i++)
            {
                Console.Write(wrong[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] != print[i])
                {
                    goto start;
                }
            }
            Console.Clear();
            Console.WriteLine("Мои поздравления");
            Console.WriteLine("Твоё слово: " + word);
            goto finish;

        finish:
            Console.ReadKey();
            Console.Clear();
        askagain:
            Console.Write("Хочешь сыграть ещё раз? <да/нет> ");
            string ask = Console.ReadLine();
            if (ask == "да")
            {
                goto firststart;
            }
            else if (ask == "нет")
            {
                Console.Clear();
                Console.WriteLine("Спасибо за игру");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введите ещё раз пожалуйста");
                goto askagain;
            }
        fullfinish:
            Console.WriteLine();
        }
        static void English()
        {
            string[] words = { "hello", "day", "dog", "line", "word", "world" };
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("                             WONDER FIELD");
            Console.WriteLine("\n");
            Console.WriteLine("                       press any key to start");
            Console.ReadKey();
            Console.Clear();
        menu:
            Console.WriteLine("                    MENU");
            Console.WriteLine("—— To start enter start");
            Console.WriteLine("—— To know rules enter rules");
            Console.WriteLine("—— To change language, enter languages");
            string menu = Console.ReadLine().ToLower();
            Console.Clear();
            if (menu == "start")
            {
                goto firststart;
            }
            else if (menu == "rules")
            {
                goto rules;
            }
            else if (menu == "languages")
            {
                goto languages;
            }
            else
            {
                goto menu;
            }
        languages:
            Console.WriteLine("                    LANGUAGES");
            Console.WriteLine("—— To translate the game to russian, enter russian");
            Console.WriteLine("—— To cancel, enter something");
            string languages = Console.ReadLine().ToLower();
            Console.Clear();
            if (languages == "russian")
            {
                Russian();
                goto fullfinish;
            }
            else
            {
                goto menu;
            }
        rules:
            Console.WriteLine("                    RULES");
            Console.WriteLine("In this game you have to answer the word");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("You have 7 attempts");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("You have 7 attempts   ] —— It's your attempts. Attempts will end —— YOU LOSE");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("_ _ _ _ _");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("_ _ _ _ _   ] —— It's your word. You have to answer it");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("Wrong letters:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                    RULES");
            Console.WriteLine("Wrong letters:   ] —— It's your wrong letters");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Press any key to go to menu");
            Console.ReadKey();
            Console.Clear();
            goto menu;
        firststart:
            Console.Clear();
            char ch;
            string b;
            int a = 0;
            string word = words[new Random().Next(0, words.Length)];
            char[] symbols = new char[word.Length];
            char[] print = new char[word.Length];
            int attempts = word.Length + 2;
            char[] wrong = new char[attempts];
            int wrongindex = 0;
        maybestartexception:
            Console.WriteLine("You have " + attempts + " attempts");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                symbols[i] = word[i];
                print[i] = '_';
                Console.Write(print[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Wrong letters: ");
        start:
            a += 0;
            Console.Write("Enter a symbol: ");
            b = Console.ReadLine();
            if (b.Length > 1 || b == "" || b == " ")
            {
                Console.Clear();
                Console.WriteLine("You need to enter only one symbol");
                Console.WriteLine("Try again");
                Console.ReadKey();
                Console.Clear();
                if (a == 1)
                {
                    goto maybestartexception;
                }
                else
                {
                    goto maybeexception;
                }
            }
            ch = char.Parse(b);
            Console.WriteLine();
            Console.Clear();
            for (int i = 0; i < word.Length; i++)
            {
                if (ch == word[i])
                {
                    print[i] = ch;
                    count += 1;
                }
            }
            if (count == 0)
            {
                wrong[wrongindex] = ch;
                wrongindex += 1;
                attempts -= 1;
                if (attempts == 0)
                {
                    Console.WriteLine("YOU LOSE!!!");
                    goto finish;
                }
            }
        maybeexception:
            Console.WriteLine(attempts + " attempts left");
            count = 0;
            foreach (var item in print)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Wrong letters: ");
            for (int i = 0; i <= wrongindex; i++)
            {
                Console.Write(wrong[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] != print[i])
                {
                    goto start;
                }
            }
            Console.Clear();
            Console.WriteLine("My Congratulations");
            Console.WriteLine("Your word is: " + word);
            goto finish;

        finish:
            Console.ReadKey();
            Console.Clear();
        askagain:
            Console.Write("Do you want to play again? <y/n> ");
            string ask = Console.ReadLine();
            if (ask == "y")
            {
                goto firststart;
            }
            else if (ask == "n")
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter again pease");
                goto askagain;
            }
        fullfinish:
            Console.WriteLine();
        }
    
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            switch (culture.ToString())
            {
                case "ru-RU":
                    Russian();
                    break;
                case "en-US":
                    English();
                    break;
                default:
                    English();
                    break;
            }
        }
    }
}

using NLog;
using Phone_Book;
using System;
using System.IO;

namespace PhoneBook_Console
{
    class Program
    {
        static bool exit = false;
        static bool allContactsDelete = false;
        static void Main(string[] args)
        {
            Class1.Start();
        start:
            Console.Clear();
            if (Directory.GetFiles("Contacts").Length > 0)
            {
                string answer = Action();
                if (answer != "All contacts has been deleted.")
                {
                    Console.Clear();
                    Console.WriteLine(answer);
                }
                else
                {
                    goto start;
                }
            }
            else
            {
                Console.Write("You don't have any contacts.\nTo add contact input contact's name: ");
                string name = Console.ReadLine();
                Console.Clear();
                try
                {
                    Console.WriteLine(Class1.AddContact(name));
                    allContactsDelete = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("You inputed incorrect name.");
                    Console.ReadKey();
                    Console.Clear();
                    goto start;
                }
                Console.ReadKey();
                Action();
                goto start;
            }
            LogManager.GetCurrentClassLogger().Info($"User finished the program.");
        }
        static string Action()
        {
        action:
            if (exit == true)
            {
                return "Thank you for using my telephone book :-)";
            }
            if (allContactsDelete == true)
            {
                return "All contacts has been deleted.";
            }
            Console.Clear();
            Console.WriteLine("What do you want to do?\n1 — Add a contact;\n2 — Edit a contact or show contact's ways to contact;\n3 — Show all contacts;\n4 — Delete a contact;\n5 — Delete all contacts;\n6 — Find a contact by part of contact's name;\n7 — Rename a contact;\nTo exit input \"exit\".");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Console.Write("Contact's name: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            Console.WriteLine(Class1.AddContact(name));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You inputed incorrect name.");
                        }
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        Console.Write("Contact's name: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        if (File.Exists($@"Contacts\{name}.txt"))
                        {
                            if (File.ReadAllLines($@"Contacts\{name}.txt").Length > 1)
                            {
                                Edit(name);
                            }
                            else
                            {
                            edit:
                                Console.Write($"You don't have any ways to contact in contact {name}.\nTo add way to contact input way's to contact name: ");
                                string wayToContact = Console.ReadLine();
                                Console.Clear();
                                if (wayToContact != "")
                                {
                                    Console.Write("Text: ");
                                    string text = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine(Class1.WriteWay(name, wayToContact, text));
                                    Console.ReadKey();
                                    Edit(name);
                                }
                                else
                                {
                                    Console.WriteLine("You inputed incorrect name.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto edit;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exists.");
                        }
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        int number = 1;
                        foreach (var item in Class1.ShowContacts())
                        {
                            Console.WriteLine(number + " — " + item);
                            number++;
                        }
                        Console.ReadKey();
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        string code = new Random().Next(1000, 10000).ToString();
                        Console.Write("Contact's name: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        if (File.Exists($@"Contacts\{name}.txt"))
                        {
                            Console.Write($"Enter {code} to delete contact {name}: ");
                            string text = Console.ReadLine();
                            Console.Clear();
                            string answer = Class1.DeleteContact(name, code, text);
                            if (Directory.GetFiles("Contacts").Length == 0)
                            {
                                allContactsDelete = true;
                                return "All contacts have been deleted.";
                            }
                            else
                            {
                                Console.WriteLine(answer);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exists.");
                        }
                        Console.ReadKey();
                    }
                    break;
                case "5":
                    {
                        Console.Clear();
                        string code = new Random().Next(1000, 10000).ToString();
                        Console.Write($"Enter {code} to delete all contacts: ");
                        string text = Console.ReadLine();
                        Console.Clear();
                        string answer = Class1.DeleteAllContacts(code, text);
                        if (answer == "All contacts have been deleted.")
                        {
                            Console.WriteLine(answer);
                            Console.ReadKey();
                            allContactsDelete = true;
                            return answer;
                        }
                        else
                        {
                            Console.WriteLine(answer);
                        }
                    }
                    break;
                case "6":
                    {
                        Console.Clear();
                        int number = 1;
                        Console.Write("Part of contact's name: ");
                        string partOfName = Console.ReadLine();
                        Console.Clear();
                        if (Class1.FindContact(partOfName).Count > 0)
                        {
                            foreach (var item in Class1.FindContact(partOfName))
                            {
                                Console.WriteLine(number + " — " + item);
                                number++;
                            }
                            Console.Write("Contact's name that you want to edit or view: ");
                            Edit(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine($"Contact with part of name {partOfName} does not exists.");
                            Console.ReadKey();
                        }
                    }
                    break;
                case "7":
                    {
                        Console.Clear();
                        Console.Write("Contacts name: ");
                        string oldName = Console.ReadLine();
                        Console.Clear();
                        if (File.Exists($@"Contacts\{oldName}.txt"))
                        {
                            Console.Write("New contact's name: ");
                            string newName = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(Class1.RenameContact(oldName, newName));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"Contact {oldName} does not exists.");
                        }
                    }
                    break;
                case "exit":
                    exit = true;
                    return "Thank you for using my telephone book :-)";
                default:
                    Console.Clear();
                    Console.WriteLine("You inputed incorrect value.");
                    Console.ReadKey();
                    break;
            }
            goto action;
        }

        private static string Edit(string name)
        {
        edit:
            Console.Clear();
            Console.WriteLine($"What do you want to do with contact {name}?\n1 — Add a way to contact;\n2 — Show all ways to contact;\n3 — Delete a way to contact;\n4 — Rename a way to contact;\nTo go to menu input \"menu\".");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Console.Write("Way to contact: ");
                        string wayToContact = Console.ReadLine();
                        Console.Clear();
                        if (wayToContact != "")
                        {
                            Console.Write("Text: ");
                            string text = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(Class1.WriteWay(name, wayToContact, text));
                        }
                        else
                        {
                            Console.WriteLine("You inputed incorrect name.");
                        }
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    Console.Clear();
                    int number = 1;
                    foreach (var item in Class1.ShowWays(name))
                    {
                        Console.WriteLine(number + " — " + item);
                        number++;
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    {
                    delete:
                        Console.Clear();
                        Console.Write("Way to contact: ");
                        string wayToContact = Console.ReadLine();
                        if (wayToContact == "")
                        {
                            goto delete;
                        }
                        Console.Clear();
                        Console.WriteLine(Class1.DeleteWay(name, wayToContact));
                        Console.ReadKey();
                        if (File.ReadAllLines($@"Contacts\{name}.txt").Length > 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write($"You don't have any ways to contact in contact {name}.\nTo add way to contact input way's to contact name: ");
                            string wayToContact2 = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Now you have to input your way's to contact text: ");
                            Class1.WriteWay(name, wayToContact2, Console.ReadLine());
                        }
                    }
                    break;
                case "4":
                    {
                        bool oldWayToContactExists = false;
                        Console.Clear();
                        Console.Write("Way to contact: ");
                        string oldWayToContact = Console.ReadLine();
                        Console.Clear();
                        foreach (var item in File.ReadAllLines($@"Contacts\{name}.txt"))
                        {
                            if (item.Contains($"{oldWayToContact}:"))
                            {
                                oldWayToContactExists = true;
                            }
                        }
                        if (oldWayToContactExists == true)
                        {
                            Console.Write("New name of way to contact: ");
                            string newWayToContact = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(Class1.RenameWay(name, oldWayToContact, newWayToContact));
                        }
                        else
                        {
                            Console.WriteLine($"Way to contact {oldWayToContact} does not exists.");
                        }
                        Console.ReadKey();
                    }
                    break;
                case "menu":
                    Console.Clear();
                    Action();
                    return "";
                default:
                    Console.Clear();
                    Console.WriteLine("You inputed incorrect value.");
                    Console.ReadKey();
                    break;
            }
            goto edit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace HOMEWORK_26
{
    class User
    {
        public string Name { get; }
        public User(string name)
        {
            Name = name;
            if (!Directory.Exists($@"Contacts\{name}"))
            {

                Directory.CreateDirectory(@$"Contacts\{name}");
                using (File.Create(@$"Contacts\{name}\userInfo")) { }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                if (!Directory.Exists("Contacts"))
                {
                    Directory.CreateDirectory("Contacts");
                }
                DirectoryInfo[] directory = new DirectoryInfo("Contacts").GetDirectories();
                List<User> users = new List<User>();
                foreach (var item in directory)
                {
                    if (Directory.GetFiles(@$"Contacts\{item.Name}").Length != 1 && Directory.GetDirectories(@$"Contacts\{item.Name}").Length != 1 && !File.Exists(@$"Contacts\{item}\userInfo"))
                    {
                        Directory.Delete(@$"Contacts\{item.Name}");
                    }
                    users.Add(new User(item.Name.ToString()));
                }
                Start(users);
            }
            static void Start(List<User> users)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n1 — Create a contact;\n2 — Delete a contact;\n3 — Show all contacts;\n4 — Rename a contact;\n5 — Delete all contacts.");
                switch (Console.ReadLine())
                {
                    case "1":
                        users = Create(users);
                        break;
                    case "2":
                        users = Delete(users);
                        break;
                    case "3":
                        ShowContacts(users);
                        break;
                    case "4":
                        users = Rename(users);
                        break;
                    case "5":
                        DeleteAll(users);
                        break;
                    default:
                        Console.WriteLine("You've input incorrect value.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Start(users);
            }
            static List<User> Create(List<User> users)
            {
                Console.Clear();
                Console.Write("Input your contact's name: ");
                string name = Console.ReadLine();
                Console.Clear();
                if (!Directory.Exists(@$"Contacts\{name}"))
                {
                    users.Add(new User(name));
                    Console.WriteLine($"Contact {name} has been successfully added to you contacts.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Contact {name} has already exists.");
                    Console.ReadKey();
                }
                return users;
            }
            static List<User> Delete(List<User> users)
            {
                Console.Clear();
                Console.Write("Input your contact's name: ");
                string name = Console.ReadLine();
                Console.Clear();
                if (Directory.Exists(@$"Contacts\{name}"))
                {
                numbers:
                    int number = new Random().Next(1000, 10000);
                    Console.Write($"To delete contact {name} input this code {number}: ");
                    if (int.Parse(Console.ReadLine()) == number)
                    {
                        Console.Clear();
                        Directory.Delete(@$"Contacts\{name}", true);
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Name == name)
                            {
                                users.Remove(users[i]);
                            }
                        }
                        Console.WriteLine($"Contact {name} has been successfully deleted from your contacts.");
                        Console.ReadKey();
                    }
                    else
                    {
                    accidentallyPressed:
                        Console.Clear();
                        Console.WriteLine("1 — To try again\n2 — If you accidentally pressed");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                goto numbers;
                            case "2":
                                return users;
                            default:
                                Console.Clear();
                                Console.WriteLine("You've input incorrect value.");
                                Console.ReadKey();
                                goto accidentallyPressed;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exists.");
                    Console.ReadKey();
                }
                return users;
            }
            static List<User> Rename(List<User> users)
            {
                Console.Clear();
                Console.Write("Input your contact's name: ");
                string oldName = Console.ReadLine();
                Console.Clear();
                if (Directory.Exists($@"Contacts\{oldName}"))
                {
                    Console.Write("Input your contact's new name: ");
                    string newName = Console.ReadLine();
                    Console.Clear();
                    if (!Directory.Exists($@"Contacts\{newName}"))
                    {
                        Directory.Move(@$"Contacts\{oldName}", @$"Contacts\{newName}");
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Name == oldName)
                            {
                                users.Remove(users[i]);
                            }
                        }
                        users.Add(new User(newName));
                        Console.WriteLine($"Contact {oldName} has been successfully renamed to contact {newName}.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Contact {newName} has already exists.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {oldName} does not exists.");
                    Console.ReadKey();
                }
                return users;
            }
            static void ShowContacts(List<User> users)
            {
                Console.Clear();
                foreach (var item in users)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadKey();
            }
            static List<User> DeleteAll(List<User> users)
            {
            numbers:
                Console.Clear();
                int number = new Random().Next(1000, 10000);
                Console.Write($"To delete all contacts input this code {number}: ");
                if (int.Parse(Console.ReadLine()) == number)
                {
                    Console.Clear();
                    foreach (var item in Directory.GetDirectories("Contacts"))
                    {
                        Directory.Delete(item, true);
                    }
                    users.Clear();
                    Console.WriteLine($"All contacts have been successfully deleted.");
                    Console.ReadKey();
                }
                else
                {
                accidentallyPressed:
                    Console.Clear();
                    Console.WriteLine("1 — To try again\n2 — If you accidentally pressed");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            goto numbers;
                        case "2":
                            return users;
                        default:
                            Console.Clear();
                            Console.WriteLine("You've input incorrect value.");
                            Console.ReadKey();
                            goto accidentallyPressed;
                    }
                }
                return users;
            }
        }
    }
}
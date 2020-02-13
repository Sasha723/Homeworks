using NLog;
using System;
using System.Collections.Generic;
using System.IO;

namespace Phone_Book
{
    public static class Class1
    {
        public static void Start()
        {
            LogManager.GetCurrentClassLogger().Info("User started the program.");
            if (!Directory.Exists("Contacts"))
            {
                LogManager.GetCurrentClassLogger().Info("Directory \"Contacts\" has been created.");
                Directory.CreateDirectory("Contacts");
            }
        }
        public static string RenameContact(string oldName, string newName)
        {
            if (!File.Exists($@"Contacts\{newName}.txt"))
            {
                File.Move($@"Contacts\{oldName}.txt", $@"Contacts\{newName}.txt");
                LogManager.GetCurrentClassLogger().Info($"User renamed contact {oldName} to contact {newName}.");
                return $"Contact {oldName} has been renamed to contact {newName}.";
            }
            else
            {
                return $"Contact {newName} has been already exists.";
            }
        }
        public static List<string> FindContact(string partOfName)
        {
            List<string> contacts = new List<string>();
            foreach (var item in Directory.GetFiles("Contacts"))
            {
                var a = item.Substring(item.LastIndexOf('\\') + 1);
                a = a.Substring(0, a.LastIndexOf('.'));
                if (a.Contains(partOfName))
                {
                    contacts.Add(a);
                }
            }
            LogManager.GetCurrentClassLogger().Info($"User found contact by part of name {partOfName}.");
            return contacts;
        }
        public static string DeleteAllContacts(string code, string text)
        {
            if (code == text)
            {
                LogManager.GetCurrentClassLogger().Info("User deleted all contacts.");
                Directory.Delete("Contacts", true);
                Directory.CreateDirectory("Contacts");
                return "All contacts have been deleted.";
            }
            else
            {
                return "You have inputed incorrect code.";
            }
        }
        public static string DeleteContact(string name, string code, string text)
        {
            if (code == text)
            {
                LogManager.GetCurrentClassLogger().Info($"User deleted contact {name}.");
                File.Delete($@"Contacts\{name}.txt");
                return $"Contact {name} has been deleted.";
            }
            else
            {
                return "You have inputed incorrect code.";
            }
        }
        public static string AddContact(string name)
        {
            if (!File.Exists($@"Contacts\{name}.txt"))
            {
                using (File.Create($@"Contacts\{name}.txt")) { }
                string guid = Guid.NewGuid().ToString();
                StreamWriter streamWriter = new StreamWriter($@"Contacts\{name}.txt");
                streamWriter.WriteLine(guid + "¶");
                streamWriter.Close();
                LogManager.GetCurrentClassLogger().Info($"User added new contact {name}.");
                return $"Contact {name} has been added.";
            }
            else
            {
                return $"Contact {name} has been already exists.";
            }
        }
        public static List<string> ShowContacts()
        {
            List<string> contacts = new List<string>();
            foreach (var item in Directory.GetFiles("Contacts"))
            {
                var a = item.Substring(item.LastIndexOf('\\') + 1);
                a = a.Substring(0, a.LastIndexOf('.'));
                contacts.Add(a);
            }
            LogManager.GetCurrentClassLogger().Info($"User showed all contacts.");
            return contacts;
        }
        public static string WriteWay(string name, string wayToContact, string wayToContactText)
        {
            bool wayToContactInFile = false;
            string[] fileText = File.ReadAllLines($@"Contacts\{name}.txt");
            foreach (var item in fileText)
            {
                if (item.Contains($"{wayToContact}:"))
                {
                    wayToContactInFile = true;
                    break;
                }
            }
            LogManager.GetCurrentClassLogger().Info($"User added new way to contact {wayToContact} in contact {name}.");
            if (wayToContactInFile == true)
            {
                string[] readText = File.ReadAllLines($@"Contacts\{name}.txt");
                for (int i = 0; i < readText.Length; i++)
                {
                    if (readText[i].Contains(wayToContact))
                    {
                        readText[i] = $"{readText[i]}, {wayToContactText}";
                    }
                }
                File.WriteAllLines($@"Contacts\{name}.txt", readText);
                return "Text has been added.";
            }
            else
            {
                if (File.ReadAllLines($@"Contacts\{name}.txt").Length > 1)
                {
                    File.AppendAllText($@"Contacts\{name}.txt", $"\n{wayToContact}: {wayToContactText}");
                }
                else
                {
                    File.AppendAllText($@"Contacts\{name}.txt", $"{wayToContact}: {wayToContactText}");
                }
                return $"Way to contact {wayToContact} has been added.";
            }
        }
        public static List<string> ShowWays(string name)
        {
            StreamReader streamReader = new StreamReader($@"Contacts\{name}.txt");
            string line = streamReader.ReadLine();
            List<string> lines = new List<string>();
            line = streamReader.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            LogManager.GetCurrentClassLogger().Info($"User showed all ways to contact in contact {name}.");
            return lines;
        }
        public static string DeleteWay(string name, string wayToContact)
        {
            string[] text = File.ReadAllLines($@"Contacts\{name}.txt");
            bool wayExists = false;
            foreach (var item in text)
            {
                if (item.Contains($"{wayToContact}:"))
                {
                    LogManager.GetCurrentClassLogger().Info($"User deleted way to contact {wayToContact} in contact {name}.");
                    wayExists = true;
                    List<string> readText = new List<string>(File.ReadAllLines($@"Contacts\{name}.txt"));
                    for (int i = 0; i < readText.Count; i++)
                    {
                        if (readText[i].Contains(wayToContact))
                        {
                            readText.Remove(readText[i]);
                        }
                    }
                    File.WriteAllLines($@"Contacts\{name}.txt", readText);
                }
            }
            if (wayExists == false)
            {
                return $"Way to contact {wayToContact} does not exists.";
            }
            else
            {
                return $"Way to contact {wayToContact} has been deleted.";
            }
        }
        public static string RenameWay(string name, string oldWayToContact, string newWayToContact)
        {
            string[] text = File.ReadAllLines($@"Contacts\{name}.txt");
            bool newWayToContactExists = false;
            foreach (var item in text)
            {
                if (item.Contains($"{newWayToContact}: "))
                {
                    newWayToContactExists = true;
                }
            }
            if (newWayToContactExists == false)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains($"{oldWayToContact}: "))
                    {
                        var a = text[i].Substring(oldWayToContact.Length + 1);
                        text[i] = $"{newWayToContact}:{a}";
                    }
                }
                File.WriteAllLines($@"Contacts\{name}.txt", text);
                LogManager.GetCurrentClassLogger().Info($"User renamed way to contact {oldWayToContact} to way to contact {newWayToContact} in contact {name}.");
                return $"Way to contact {oldWayToContact} has been renamed to way to contact {newWayToContact}.";
            }
            else
            {
                return $"Way to contact {newWayToContact} has been already exists.";
            }
        }
    }
}

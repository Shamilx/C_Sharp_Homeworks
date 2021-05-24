
using System;
using System.Collections.Generic;
using System.IO;

namespace Source
{
    static class EditMenu
    {
        public static void Start(string path)
        {
            if (!(File.Exists(path)))
                throw new InvalidDataException("Please input correct name for your Dictianory");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1) Add Word");
                Console.WriteLine("2) Delete Word");
                Console.WriteLine("3) Add translations to word ");
                Console.WriteLine("4) Exit");

                Console.Write("\nInput: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddWord(path);
                        break;
                    case "2":
                        DeleteWord(path);
                        break;
                    case "3":
                        AddTranslations(path);
                        break;
                    case "4":
                        return;
                    default:
                        throw new Exception("Please give correct input!");
                }
            }
        }

        private static void AddTranslations(string path)
        {
            DisplayInsideOfDictionary(path);

            Console.Write("\nSelect the ID of word for adding translation to it : ");

            string ID = Console.ReadLine();

            string[] lines = File.ReadAllLines(path);

            for(int i = 0;i < lines.Length;i++)
            {
                if (lines[i].Substring(0, (lines[i].IndexOf(")") == -1 ? 1 : lines[i].IndexOf(")"))) == ID)
                {
                    Console.Clear();
                    
                    Console.WriteLine("Your word found,provide the translation that is going to be added it : ");
                    string input2 = Console.ReadLine();

                    lines[i] = lines[i] + "-" + input2;
                    break;
                }
            }

            File.WriteAllLines(path,lines);
        }

        private static void DeleteWord(string path)
        {
            DisplayInsideOfDictionary(path);

            Console.WriteLine();

            string ID = Source.ConsoleGUI.BadUI.GetInputWithMessage("Please provide the ID of the word that is going to be deleted : ");

            DeleteWordWithID(path, ID);
        }

        private static void DeleteWordWithID(string path, string ID)
        {
            List<string> linesList = new List<string>(File.ReadAllLines(path));

            for (int i = 0; i < linesList.Count; i++)
            {
                if (linesList[i] != String.Empty)
                {
                    if (linesList[i].Substring(0, (linesList[i].IndexOf(")") == -1 ? 1 : linesList[i].IndexOf(")"))) == ID)
                    {
                        linesList.RemoveAt(i);
                        break;
                    }
                }
            }
            
            SortForId(linesList);

            File.WriteAllLines(path, linesList.ToArray());
        }

        private static void SortForId(List<string> linesList)
        {
            int count = 0;

            for(int i = 1;i < linesList.Count;i++)
            {
                linesList[i] = linesList[i].Replace(linesList[i].Substring(0,1),(count.ToString() == "00") ? "0" : count.ToString());
                count++;
            }
        }

        private static void AddWord(string path)
        {
            string input = Source.ConsoleGUI.BadUI.GetInputWithMessage("Please input word that is going to be added(Without translation) : ");

            using (StreamWriter obj = new(path, true))
            {
                obj.WriteLine("0)" + input);
            }

            List<string> myList = new List<string>(File.ReadAllLines(path));

            SortForId(myList);

            File.WriteAllLines(path,myList.ToArray());

        }

        public static void DisplayInsideOfDictionary(string path)
        {
            string line;

            using (StreamReader obj = new StreamReader(path))
            {
                while ((line = obj.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
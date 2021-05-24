
using System;
using System.Collections.Generic;
using System.IO;

namespace Source
{
    static class SearchMenu
    {
        public static void StartMenu(string path)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1.Search for a word(With ID)");
                Console.WriteLine("2.Search for a word(With Value)");
                Console.WriteLine("3.Export a translation of word(You need ID)");
                Console.WriteLine("4.Exit");

                Console.WriteLine("\nInput : ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SearchWithId(path);
                        break;
                    case "2":
                        SearchWithValue(path);
                        break;
                    case "3":
                        ExportWord(path);
                        break;
                    case "4":
                        return;
                    default:
                        throw new Exception("Please give correct input!");
                }

            }

        }


        private static void SearchWithId(string path)
        {
            Console.Clear();

            EditMenu.DisplayInsideOfDictionary(path);

            Console.WriteLine("\nPlease provide the ID of word : ");
            string ID = Console.ReadLine();

            string resultLine = "";
            using (StreamReader obj = new(path))
            {
                string line;

                while ((line = obj.ReadLine()) != null)
                {
                    if (line.Substring(0, (line.IndexOf(")") == -1 ? 1 : line.IndexOf(")"))) == ID)
                    {
                        resultLine = line;
                        break;
                    }
                }

                Console.Clear();

                Console.WriteLine(resultLine);

                Console.WriteLine("\n\nPlease press anything to get back");
                Console.ReadKey();
            }
        }

        private static void SearchWithValue(string path)
        {
            Console.Clear();

            EditMenu.DisplayInsideOfDictionary(path);

            Console.WriteLine("Please provide the word that is going to be searched in whole dictianory : ");
            string input = Console.ReadLine();

            List<string> ResultList = new List<string>();

            using (StreamReader obj = new(path))
            {
                string line;

                while ((line = obj.ReadLine()) != null)
                {
                    string[] splittedLines = line.Split("-");

                    if (splittedLines != null)
                    {
                        splittedLines[0] = splittedLines[0].Replace(
                            splittedLines[0].Substring(0, (line.IndexOf(")") == -1 ? 1 : line.IndexOf(")") + 1)),
                            String.Empty).Trim();


                        foreach (var i in splittedLines)
                        {
                            if (input == i)
                            {
                                ResultList.Add(line);
                                break;
                            }
                        }
                    }
                }
            }

            Console.Clear();

            foreach (var i in ResultList)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\nPlease press anything to get back");
            Console.ReadKey();
        }

        private static void ExportWord(string path)
        {
            Console.Clear();

            EditMenu.DisplayInsideOfDictionary(path);

            Console.WriteLine("\nPlease provide the ID of word that is going to be exported : ");
            string input = Console.ReadLine();

            string exportLine = "";

            using(StreamReader obj = new StreamReader(path))
            {
                string line;
                
                while((line = obj.ReadLine()) != null)
                {
                    if(line.Substring(0,(line.IndexOf(")") == -1 ? 1 : line.IndexOf(")"))) == input)
                    {
                        exportLine = line;
                        break;
                    }
                }
            }
            
            int lastIndex = path.LastIndexOf("/");

            string copyPath = path.Remove(lastIndex,path.Length - lastIndex);
            copyPath = copyPath + "/export.txt";

            if(File.Exists(copyPath))
                File.Delete(copyPath);
            
            File.Create(copyPath).Dispose();

            using(StreamWriter obj = new(copyPath))
            {
                obj.WriteLine(exportLine);
            }
        }

    }
}
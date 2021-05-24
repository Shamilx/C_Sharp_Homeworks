
using System;
using System.IO;

namespace Source.ConsoleGUI
{
    static class BadUI
    {
        public static void StartMenu()
        {
            string input;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1) Create a new Dictianory.");
                Console.WriteLine("2) Edit the Dictianory.");
                Console.WriteLine("3) Delete the Dictianory.");
                Console.WriteLine("4) Search in Dictianory");
                Console.WriteLine("5) Exit");


                Console.Write("Input : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        string name = GetInputWithMessage("Please provide a name for dictianory : ");
                        new Source.Dictianory(name);
                        break;

                    case "2":
                        if (!DisplayDictonaries())
                            continue;

                        string local = GetInputWithMessage("Please provide the name of Dictianory that is going to be edited : ");
                        Source.EditMenu.Start(Dictianory.DIRECTORY_FOLDER_PATH + "/" + local + "/" + local + ".txt");

                        break;

                    case "3":
                        if (!DisplayDictonaries())
                            continue;

                        string deletedFile = GetInputWithMessage("Please provide the name of Dictianory that is going to be deleted : ");
                        Directory.Delete(Dictianory.DIRECTORY_FOLDER_PATH + "/" + deletedFile, true);
                        break;

                    case "4":
                        if (!DisplayDictonaries())
                            continue;
                        
                        string test = GetInputWithMessage("Please provide the name of Dictianory : ");

                        SearchMenu.StartMenu(Dictianory.DIRECTORY_FOLDER_PATH + "/" + test + "/" + test + ".txt");
                        break;
                    case "5":
                        GC.Collect();
                        return;

                    default:
                        throw new Exception("Please give correct input!");
                }
            }
        }

        public static string GetInputWithMessage(string msg)
        {
            Console.Write(msg);
            string myValue = Console.ReadLine();
            Console.Clear();
            return myValue;
        }

        private static bool DisplayDictonaries()
        {
            Console.WriteLine();

            string path = Source.Dictianory.DIRECTORY_FOLDER_PATH;

            var Dirs = Directory.GetDirectories(path);

            if (Dirs == null)
            {
                return false;
            }

            foreach (var i in Dirs)
            {
                Console.WriteLine(i.Remove(0, 20).Replace(".txt", ""));
            }

            return true;
        }
    }
}
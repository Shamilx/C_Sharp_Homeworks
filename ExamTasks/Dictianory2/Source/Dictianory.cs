using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Source
{
    class Dictianory
    {
        public const string DIRECTORY_FOLDER_PATH = "Source/Dictianories";

        public string Name { get; set; }
        public string PathOfDirectory { get; set; }
        public string PathOfTxtFile { get; set; }
        public List<string> Languages { get; set; }

        public Dictianory(string name)
        {
            if (!(Regex.IsMatch(name, @"^[a-zA-Z]+$")))
                throw new InvalidDataException("Provide the name with letters please.");

            Name = name;
            Languages = null;

            PathOfDirectory = DIRECTORY_FOLDER_PATH + "/" + Name;
            PathOfTxtFile = PathOfDirectory + "/" + Name + ".txt";

            CreateDictianory();
        }

        private void CreateDictianory()
        {
            Languages = GetLangaugeOfDictianory();

            CreateDirectory(PathOfDirectory);

            CreateTxtFileForDictianory(PathOfTxtFile);

             // Adds Example&Example&0 to the top of txt file,Example refers to language in here and 0 is WordsCount
            SetDefaultHeader();
        }

        private void SetDefaultHeader()
        {
            using(StreamWriter obj = new StreamWriter(PathOfTxtFile))
            {
                obj.WriteLine(Languages[0] + "&" + Languages[1]);
            }
        }

        private static void CreateTxtFileForDictianory(string Path)
        {

            if (File.Exists(Path))
            {
                Directory.Delete(Path);
                throw new Exceptions.FileExsists("That was impossible,congrats that you achived it.");
            }

            File.Create(Path).Dispose();
        }

        private static List<string> GetLangaugeOfDictianory()
        {
            Console.Clear();

            string input1;
            string input2;

            Console.WriteLine("Please provide Dictianory's language type:");

            Console.Write("Language From : ");
            input1 = Console.ReadLine();

            Console.Write("Language To : ");
            input2 = Console.ReadLine();

            if (!(Regex.IsMatch(input1, @"^[a-zA-Z]+$") && Regex.IsMatch(input2, @"^[a-zA-Z]+$")))
                throw new InvalidDataException("Provide the name of language with letters please.");

            Console.Clear();

            return new List<string>() { input1, input2 };
        }

        // For Creating Folder for Dictianory
        private static void CreateDirectory(string path)
        {
            if (Directory.Exists(path))
                throw new Exceptions.FileExsists("Select different name for Dictianory.");

            Console.WriteLine(path);
            Directory.CreateDirectory(path);

        }
    }
}
using System;
using System.IO;
using System.Text.RegularExpressions;

using src.Exceptions;
using src.Classes;

namespace src.BadUI
{
    static class BadUI
    {
        public static void StartMenu()
        {
            if(File.Exists(User.USER_LIST_PATH))
                File.WriteAllText(User.USER_LIST_PATH,String.Empty);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome who are you?\n");

                Console.WriteLine("1) User");
                Console.WriteLine("2) Admin");
                Console.WriteLine("3) Exit");

                string input = GetInputFromUser("Input: ");

                switch (input)
                {
                    case "1":
                        UserMenu();
                        break;
                    case "2":
                        AdminMenu();
                        break;
                    case "3":
                        return;
                    default:
                        throw new InvalidInputException("Please provide the input correctly!");
                }
            }
        }

        private static void AdminMenu()
        {
            Admin admin = new Admin();

            Console.Clear();
            string input = GetInputFromUser("Password of Admin : "); // admin

            if (input != "admin")
                return;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome Admin");

                Console.WriteLine("1) Select Users.");
                Console.WriteLine("2) Start Exam.");
                Console.WriteLine("3) Exit");
                string selection = GetInputFromUser("Input : ");

                switch (selection)
                {
                    case "1":
                        BadUiMethods.SelectUsers(admin);
                        break;
                    case "2":
                        BadUiMethods.StartExam(admin);
                        break;
                    case "3":
                        return;
                    default:
                        throw new InvalidInputException("Please provide correct input!");
                }
            }
        }

        private static void UserMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome User\n");

                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                Console.WriteLine("3) Exit");

                string input = GetInputFromUser("Input: ");

                switch (input)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        RegisterMenu();
                        break;
                    case "3":
                        return;
                    default:
                        throw new InvalidInputException("Please provide the input correctly!");
                }
            }
        }

        private static void RegisterMenu()
        {
            Console.Clear();

            string username = GetInputFromUser("Name: ");
            string password = GetInputFromUser("Password: ");

            if (username == String.Empty || password == String.Empty)
                throw new UsernameOrPasswordIncorrect("Please provide name and password correctly!");

            if (Regex.IsMatch(username, "^(?=.*[a-zA-Z])(?=.*[0-9])") && Regex.IsMatch(password, "^(?=.*[a-zA-Z])(?=.*[0-9])"))
                throw new UsernameOrPasswordIncorrect("Please provide name and password without symbols!");


            new User(username, password);
        }

        private static void LoginMenu()
        {
            Console.Clear();

            string name = GetInputFromUser("Name: ");
            string password = GetInputFromUser("Password: ");

            if (!(BadUiMethods.CheckUsernameAndPassword(name, password)))
                throw new UsernameOrPasswordIncorrect();

            BadUiMethods.StartExamOfUser(name, password);
        }

        private static string GetInputFromUser(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
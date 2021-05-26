using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using src.Classes;
using src.Exceptions;

namespace src.BadUI
{
    static class BadUiMethods
    {
        public static bool CheckUsernameAndPassword(string username, string password)
        {
            if (username == String.Empty || password == String.Empty)
                throw new UsernameOrPasswordIncorrect("Please provide name and password correctly!");

            if (Regex.IsMatch(username, "^(?=.*[a-zA-Z])(?=.*[0-9])") && Regex.IsMatch(password, "^(?=.*[a-zA-Z])(?=.*[0-9])"))
                throw new UsernameOrPasswordIncorrect("Please provide name and password without symbols!");

            string[] lines = UserListMethods.GetLines();

            return UserListMethods.CheckIfUserExsists(lines, username, password);
        }

        public static void StartExamOfUser(string username, string password)
        {
            var ExamUsers = User.UserList;

            for (int t = 0; t < ExamUsers.Count; t++)
            {
                if (username == ExamUsers[t].GetUsername() && password == ExamUsers[t].GetPassword())
                {
                    if (ExamUsers[t].CheckExam())
                    {
                        ExamUsers[t].Display();
                        return;
                    }
                }
            }


            Console.Clear();
            Console.WriteLine("Your exam is not started by Admin...");
            Console.ReadKey();

        }

        public static void SelectUsers(Admin admin)
        {
            while (true)
            {
                Console.Clear();

                foreach (var i in User.UserList)
                {
                    if (!(admin.SelectedUsers.Contains(i)))
                    {
                        Console.WriteLine(i.GetUsername());
                    }
                }

                Console.Write("\nInput(Name of student/x for exit):");
                string input = Console.ReadLine();

                if (input == "x")
                    return;

                foreach (var i in User.UserList)
                {
                    if(i.GetUsername() == input)
                    {
                        admin.SubscribeUser(i);
                        Console.WriteLine("Subscribed");
                        Console.ReadKey();
                        
                        break;
                    }
                }
            }
        }

        public static void StartExam(Admin admin)
        {
            admin.StartExam();
        }
    }
}
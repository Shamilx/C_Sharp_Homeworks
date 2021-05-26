using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using src.Exceptions;

namespace src.Classes
{
    class User
    {
        private string _username;
        private string _password;
        private bool _haveExam;
        public const string USER_LIST_PATH = @"src\Data\UserList.txt";
        
        public static List<User> UserList = new List<User>();

        public User(string username, string password)
        {
            _username = username;
            _password = password;

            UserList.Add(this);
            RegisterUser();
        }

        public void RegisterUser()
        {
            if (_username == String.Empty || _password == String.Empty)
                throw new UsernameOrPasswordIncorrect("Please provide name and password correctly!");

            if (Regex.IsMatch(_username, "^(?=.*[a-zA-Z])(?=.*[0-9])") && Regex.IsMatch(_password, "^(?=.*[a-zA-Z])(?=.*[0-9])"))
                throw new UsernameOrPasswordIncorrect("Please provide name and password without symbols!");

            SaveUserToList();
        }

        private void SaveUserToList()
        {
            using (StreamWriter obj = new StreamWriter(USER_LIST_PATH))
            {
                obj.WriteLine(_username + "&" + _password);
            }
        }

        public bool CheckExam()
        {
            return _haveExam;
        }

        public void StartExam()
        {
            _haveExam = true;
        }

        public void Display()
        {
            Console.WriteLine("Your exam started");
            Console.ReadKey();
        }

        public string GetUsername() { return _username; }
        public string GetPassword() { return _password; }
    }
}
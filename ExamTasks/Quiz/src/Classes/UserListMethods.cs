using System;
using System.IO;
using System.Collections.Generic;

namespace src.Classes
{
    static class UserListMethods
    {
        private const string USER_LIST_PATH = @"src\Data\UserList.txt";
        
        public static string[] GetLines() => File.ReadAllLines(USER_LIST_PATH);

        public static bool CheckIfUserExsists(string[] lines,string username,string password)
        {
            for(int i = 0;i < lines.Length;i++)
            {
                string[] usernameAndPassword = lines[i].Split("&");

                string username1 = usernameAndPassword[0];
                string password1 = usernameAndPassword[1];

                if(username1 == username && password1 == password)
                    return true;
            }
            
            return false;
        }
    }
}
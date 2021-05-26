using System;
using System.Collections.Generic;

namespace src.Classes
{
    class Admin
    {
        public delegate void ExamDelegate();

        public event ExamDelegate ExamStarter;
        
        public List<User> SelectedUsers = new List<User>();

        public void SubscribeUser(User user)
        {
            ExamStarter += user.StartExam;
        }

        public void StartExam()
        {   
            ExamStarter();
        }

    }
}
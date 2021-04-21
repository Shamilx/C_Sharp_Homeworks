using System.Collections.Generic;

namespace iWillPickYouNameLater
{
    enum Groups
    {
        FSDE_12014,
        FBE_12013,
    }

    enum Mark
    {
        SO_BAD = 2,
        BAD = 3,
        NORMAL = 4,
        GREAT = 5
    }
	
    class Student
    {
        List<Mark> Marks = new List<Mark>();
        string FirstName;
        string LastName;
        Groups? Group = null;
        int Age;
        

        public Student(string firstName,string lastName,Groups group,int age)
            :this(firstName,lastName)
        {
            Group = group;
            Age = age;
        }

        public Student(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName,string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        // Setters
        public void setFirstName(string name) { FirstName = name; }
        public void setLastName(string name)  { LastName = name;  }
        public void setGroup(Groups group)    { Group = group;    }
        public void setAge(int _age)          { Age = _age;       }
        
        // Getters
        public string getFirstName() { return FirstName; }
        public string getLastName()  { return LastName;  }
        public Groups? getGroup()     { return Group;     }
        public int getAge()          { return Age;       }

        public void addMark(Mark mark) { Marks.Add(mark); }

        //print out info about student
        public void print()
        {
            System.Console.WriteLine("Name : " + FirstName);
            System.Console.WriteLine("Last Name : " + LastName);
            
            if(Group != null)
                System.Console.WriteLine("Group : " + Group);

            if(Age != 0)
                System.Console.WriteLine("Age : " + Age);

            
            System.Console.WriteLine("\nMarks : ");

            foreach (Mark i in Marks)
            {
                System.Console.WriteLine(i);
            }
        }


    }
}
using System;
using WOT;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Fight();
        }
        
        static void Fight()
        {
            Pantera[] panteras = new Pantera[5];
            T34[] t34s = new T34[5];

            int destroyedPanteras = 0;
            int destroyedT34s = 0;


            for(int i = 0;i < 5;i++)
            {
                panteras[i] = new();
                t34s[i] = new();
            }

            for(int i = 0;i < 5;i++)
            {
                System.Console.WriteLine();

                Console.Write("Pantera\t\t\tT34\n");

                Console.Write(panteras[i].GetAmmunition() + "\t\t\t" 
                    + t34s[i].GetAmmunition() + '\n');
                
                Console.Write(panteras[i].GetArmor() + "\t\t\t" 
                    + t34s[i].GetArmor() + '\n');

                Console.Write(panteras[i].GetManeuverability() + "\t\t\t" 
                    + t34s[i].GetManeuverability() + '\n');
                
                Base winner = panteras[i] * t34s[i];

                if(winner is Pantera)
                {
                    System.Console.Write("\n\t\tPantera WON!");
                    destroyedT34s++;
                }
                else if(winner is T34)
                {
                    System.Console.Write("\n\t\tT34 WON!");
                    destroyedPanteras++;
                }

                System.Console.WriteLine();
            }

            if(destroyedPanteras > destroyedT34s)
            {
                System.Console.WriteLine("\n\n\n\t\tWINNER : T34 WON");
            }
            else if(destroyedPanteras < destroyedT34s)
            {
                System.Console.WriteLine("\n\n\n\t\tWINNER : PANTERAS");
            }
            else
            {
                System.Console.WriteLine("\n\n\n\t\tDRAW");
            }
        }
    }
}

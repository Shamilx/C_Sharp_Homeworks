using System;

// cant work with negative numbers;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main()
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = f * a;
            double d = 1.5;
            Fraction f3 = f + d;

            f.print();
            f3.print();

            if(f) { Console.WriteLine("f kesri duz kesrdir"); }
            else { Console.WriteLine("f kesri duz olmayan kesrdir"); };
            
            if(f3) { Console.WriteLine("f3 kesri duz kesrdir"); }
            else { Console.WriteLine("f3 kesri duz olmayan kesrdir");  };
        }
    }
}
using System;

namespace ConsoleApplication44
{
    abstract class Drawer
    {
        public ConsoleColor Color;
        public abstract void Draw();
    }

    class Triangle : Drawer
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        private void check(double firstSide, double secondSide, double thirdSide)
        {
            double max = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            if ((firstSide + secondSide + thirdSide) - max <= max)
            {
                throw new Exception("Check sides");
            }
        }


        public Triangle(double firstSide, double secondSide, double thirdSide, ConsoleColor color)
        {
            check(firstSide, secondSide, thirdSide);
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            Color = color;
        }

        public override void Draw()
        {
            Console.BackgroundColor = Color;
            int val = (int)_firstSide;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

    }

    class Square : Drawer
    {
        private double _side;


        public Square(double side,ConsoleColor color)
        {
            if(side <= 0)
                throw new Exception("Check side");

            _side = side;
            Color = color;
        }


        public override void Draw()
        {
            for(int i = 0;i < (int)_side;i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < (int)(_side) - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < (int)(_side) - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }


            for(int i = 0;i < (int)_side;i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

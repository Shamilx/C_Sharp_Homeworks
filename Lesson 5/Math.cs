using System;

namespace Hey
{
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimetr();
    }

    class Romb : Figure
    {
        double[] Terefler = new double[4];
        int p, q; // diagonals

        
        public Romb(double a, double b, double c, double d) 
        {
            Terefler[0] = a;
            Terefler[1] = b;
            Terefler[2] = c;
            Terefler[3] = d;
        }


        public override double Area()
        {
            if(p == 0 || q == 0)
            {
                throw new Exception("ERROR");
            }

            return (p * q) / 2;
        }

        public override double Perimetr()
        {
            double sum = 0;
            foreach (var item in Terefler)
            {
                sum = sum + item;
            }

            return sum;
        }

        public void setDiagonal1(int p1)
        {
            p = p1;
        }

        public void setDiagonal2(int q1)
        {
            q = q1;
        }
    }

    class Square : Figure
    {
        double Teref;

        public Square(double _teref)
        {
            Teref = _teref;
        }

        public override double Area()
        {
            return Teref * Teref;
        }

        public override double Perimetr()
        {
            return 4 * Teref;
        }
    }

    class Triangle : Figure
    {
        double[] Terefler = new double[3];
        double Base;

        public Triangle(double a,double b,double c)
        {
            Terefler[0] = a;
            Terefler[1] = b;
            Terefler[2] = c;
        }

        public override double Perimetr()
        {
            return Terefler[0] + Terefler[1] + Terefler[2];
        }

        public override double Area()
        {
            return (Terefler[1] * Base) / 2;
        }

        void setBase(int q) { Base = q; }
    }

    class Rectangle : Figure
    {
        double[] Terefler = new double[2];

        public Rectangle(double a,double b)
        {
            Terefler[0] = a;
            Terefler[1] = b;
        }

        public override double Area()
        {
            return Terefler[0] * Terefler[1];
        }

        public override double Perimetr()
        {
            return 2 * (Terefler[0] + Terefler[1]);
        }
    }
}
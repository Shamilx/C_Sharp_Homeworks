using System;

namespace ConsoleApplication36
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;


        public Fraction(int numerator, int denominator = 1)
        {
            _numerator = numerator;
            _denominator = denominator;
        }


        private static Fraction reduction(int numerator, int denominator)
        {
            if (numerator == denominator)
            {
                return new Fraction(1);
            }
            else if (numerator % denominator == 0)
            {
                return new Fraction(numerator / denominator);
            }
            else if (denominator % numerator == 0)
            {
                return new Fraction(1, denominator / numerator);
            }
            else
            {
                int littleOne = numerator > denominator ? denominator : numerator;

                for (int i = littleOne; i > 0; i--)
                {
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        return new Fraction(numerator / i, denominator / i);
                    }
                }
            }

            throw new Exception("Reduction failed");
        }

        // +
        public static Fraction operator +(Fraction first, Fraction second)
        {
            // 2/4 + 2/3 | if(_denom1 == _denom2) _num1 + _num2
            // else num1 = num1 * _denom2 num2 = num2 * _denom1
            // return new Frac(if(!ixtisar)num1 + num2,_denom1 * _denom2)
            // else { find(num1 num2 Ebob bol ona)}

            if (first._denominator == second._denominator)
            {
                return reduction(first._numerator + second._numerator, first._denominator);
            }
            else
            {
                int firstNum = first._numerator;
                int secondNum = second._numerator;

                int firstdDenom = first._denominator;
                int secondDenom = second._denominator;

                return reduction(firstNum * secondDenom + secondNum * firstdDenom, firstdDenom * secondDenom);
            }

            throw new Exception("failed");
        }

        public static Fraction operator +(Fraction first, int num)
        {
            return reduction(first._numerator + first._denominator * num, first._denominator);
        }

        public static Fraction operator +(Fraction first, double num)
        {
            string num2 = num.ToString();
            int length = num2.Length;

            string[] arr = num2.Split('.');

            int firstPart = (int)(double.Parse(arr[0]) * Math.Pow(10, length - 1));
            int secondPart = (int)Math.Pow(10, length - 1);

            Fraction second = new Fraction(firstPart, secondPart);
            return first + second;

        }

        // -
        public static Fraction operator -(Fraction first, Fraction second)
        {
            if (first._denominator == second._denominator)
            {
                return reduction(first._numerator - second._numerator, first._denominator);
            }
            else
            {
                int firstNum = first._numerator;
                int secondNum = second._numerator;

                int firstdDenom = first._denominator;
                int secondDenom = second._denominator;

                return reduction(firstNum * secondDenom - secondNum * firstdDenom, firstdDenom * secondDenom);
            }

            throw new Exception("failed");
        }

        public static Fraction operator -(Fraction first, int num)
        {
            return reduction(first._numerator - first._denominator * num, first._denominator);
        }

        public static Fraction operator -(Fraction first, double num)
        {
            string num2 = num.ToString();
            int length = num2.Length;

            string[] arr = num2.Split('.');

            int firstPart = (int)(double.Parse(arr[0]) * Math.Pow(10, length - 1));
            int secondPart = (int)Math.Pow(10, length - 1);

            Fraction second = new Fraction(firstPart, secondPart);
            return first - second;
        }

        // /
        public static Fraction operator /(Fraction first, Fraction second)
        {
            return reduction(first._numerator * second._denominator, first._denominator * second._numerator);
        }

        public static Fraction operator /(Fraction first,int num)
        {
            return reduction(first._numerator, first._denominator * num);
        }

        public static Fraction operator /(Fraction first,double num)
        {
            string num2 = num.ToString();
            int length = num2.Length;

            string[] arr = num2.Split('.');

            int firstPart = (int)(double.Parse(arr[0]) * Math.Pow(10, length - 1));
            int secondPart = (int)Math.Pow(10, length - 1);

            Fraction second = new Fraction(firstPart, secondPart);
            return first / second;
        }

        // *
        public static Fraction operator *(Fraction first, Fraction second)
        {
            return reduction(first._numerator * second._numerator, first._denominator * second._denominator);
        }

        public static Fraction operator *(Fraction first, int num)
        {
            return reduction(first._numerator * num, first._denominator);
        }

        public static Fraction operator *(Fraction first,double num)
        {
            string num2 = num.ToString();
            int length = num2.Length;

            string[] arr = num2.Split('.');

            int firstPart = (int)(double.Parse(arr[0]) * Math.Pow(10, length - 1));
            int secondPart = (int)Math.Pow(10, length - 1);

            Fraction second = new Fraction(firstPart, secondPart);
            return first * second;
        }
		
        // relational
        public static bool operator ==(Fraction first, Fraction second)
        {
            if (((double)first._numerator / (double)first._denominator) == ((double)second._numerator / (double)second._denominator))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Fraction first, Fraction second)
        {
            if (((double)first._numerator / (double)first._denominator) != ((double)second._numerator / (double)second._denominator))
            {
                return true;
            }

            return false;
        }

        public static bool operator >(Fraction first, Fraction second)
        {
            if (((double)first._numerator / (double)first._denominator) > ((double)second._numerator / (double)second._denominator))
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Fraction first, Fraction second)
        {
            if (((double)first._numerator / (double)first._denominator) < ((double)second._numerator / (double)second._denominator))
            {
                return true;
            }

            return false;
        }

        public void print()
        {
            if (_denominator != 1)
            {
                Console.WriteLine(_numerator + " / " + _denominator);
            }
            else
            {
                Console.WriteLine(_numerator);
            }
        }

        public static bool operator true(Fraction frac)
        {
            if (frac._numerator < frac._denominator)
                return true;

            return false;
        }

        public static bool operator false(Fraction frac)
        {
            if (frac._numerator >= frac._denominator)
                return false;

            return true;
        }

        public void printReducted()
        {
            Fraction reducted = reduction(_numerator, _denominator);
            reducted.print();
        }

        public static void printReducted(Fraction frac)
        {
            Fraction reducted = reduction(frac._numerator, frac._denominator);
            reducted.print();
        }
    }
}

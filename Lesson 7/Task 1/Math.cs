
using System;

namespace FirstConsoleApp
{
    abstract class GeometricalFigure
    {
        public double FigureArea;
        public double FigurePerimetr;
    }

    interface ISimpleNGon
    {
        public double Height        { get; } 
        public double Base          { get; }           // Base of Figure
        public double Area          { get; }           
        public double Perimetr      { get; }       
        public double NumberOfSides { get; }  // How many sides
    }

    class Triangle : GeometricalFigure,ISimpleNGon
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double _height;


        private void check(double firstSide,double secondSide,double thirdSide)
        {
            double max = Math.Max(firstSide,Math.Max(secondSide,thirdSide));
            if((firstSide + secondSide + thirdSide) - max <= max)
            {
                throw new Exception("Check sides");
            }
        }


        public Triangle(double firstSide,double secondSide,double thirdSide,double __height)
        {
            check(firstSide,secondSide,thirdSide);
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            _height = __height;
            
            FigurePerimetr = _firstSide + _secondSide + _thirdSide;
            FigureArea = Height * Base / 2;
        }


         public double Height => _height;

         public double Base => _secondSide;

         public double Area => FigureArea;

         public double Perimetr => FigurePerimetr;

         public double NumberOfSides => 3;
     }

    class Square : GeometricalFigure,ISimpleNGon
    {
        private double _side;


        public Square(double side)
        {
            if(side <= 0)
                throw new Exception("Check side");

            _side = side;

            FigureArea = _side * _side;
            FigurePerimetr = _side * _side;
        }


        public double Height => _side;

        public double Base => _side;

        public double Area => FigureArea;

        public double Perimetr => FigurePerimetr;

        public double NumberOfSides => 4;
    }

    class Rhombus : GeometricalFigure,ISimpleNGon
    {
        private double _side;
        private double _pDiagnal;
        private double _qDiagonal;


        public Rhombus(double side,double pDiagonal,double qDiagonal)        
        {
            if(side <= 0)
                throw new Exception();

            _side = side;

            FigureArea = (_pDiagnal * _qDiagonal) / 2;
            FigurePerimetr = _side * 4;
        }


        public double Height => _side;

        public double Base => Area / Height;

        public double Area => FigureArea;

        public double Perimetr => FigurePerimetr;

        public double NumberOfSides => 4;

    }

    class Rectangle : GeometricalFigure
    {
        private double _side1;
        private double _side2;


        public Rectangle(double side1,double side2)
        {
            if(side1 <= 0 || side2 <= 0)
                throw new Exception("check sides");

            _side1 = side1;
            _side1 = side2;

            FigureArea = _side1 * _side2;
            FigurePerimetr = 2 * (_side1 + _side2);

        }


        public double Height => Math.Max(_side1,_side2);

        public double Base => _side2;

        public double Area => FigureArea;

        public double Perimetr => FigurePerimetr;

        public double NumberOfSides => 4;
    }

    class Circle : GeometricalFigure, ISimpleNGon
    {
        double _radius;


        public Circle(double radius)
        {
            _radius = radius;

            FigureArea = Math.PI * (_radius * _radius);
            
        }


        public double Height => throw new Exception("It is circle!");

        public double Base => throw new Exception("It is circle!");

        public double Area => FigureArea;

        public double Length => 2 * Math.PI * _radius; 

        public double Perimetr => throw new Exception("It is circle!");

        public double NumberOfSides => throw new Exception("It is circle!");
    }
}
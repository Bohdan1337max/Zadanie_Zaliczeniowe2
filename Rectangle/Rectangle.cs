using System;

namespace Rectangle
{
    public class Rectangle
    {
        private double _diagonal,
            _sideA,
            _sideB;
        

        public double SideA
        {
            get => _sideA;
            set
            {
                _sideA = value;
               _diagonal = Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2));
               
            }
        }


        public double SideB
        {
            get => _sideB;
            set
            {
                _sideB = value;
                _diagonal = Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2));
            }
        }

        
        public double Diagonal
        {
            get => _diagonal;
            set
            {
                _diagonal = value;
                _sideB = Math.Sqrt(Math.Pow(_diagonal, 2) - Math.Pow(_sideA, 2));;

            }
        } 

        public double Field => _sideA * _sideB;

        public double Perimeter => SideA * 2 + SideB * 2;

        public override  string ToString()
        {
            return $"\n SideA:  {SideA}" +
                   $"\n SideB:  {SideB}" +
                   $"\n Diagonal:   {Diagonal}" +
                   $"\n Field:  {Field}" +
                   $"\n Perimeter:   {Perimeter}" +
                   "\n MATH"+
            $"\n SquareRootOfTwo:    {MyMath.SquareRootOfTwo}" +
            $"\n ReciprocalOfTheRootOfTwo:   {MyMath.ReciprocalOfTheRootOfTwo}" +
            $"\n SquareRootOfThree:  {MyMath.SquareRootOfThree}" +
            $"\n ReciprocalRootOfThree:  {MyMath.ReciprocalOfTheRootOfThree}" +
            $"\n Fi: {MyMath.Fi}" +
            $"\n ReciprocalOfFi: {MyMath.ReciprocalOfFi}";
        }

        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
          
        }
    }
}
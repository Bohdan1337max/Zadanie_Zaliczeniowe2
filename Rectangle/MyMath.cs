using System;

namespace Rectangle
{
    public static class MyMath
    {
        
        public static double SquareRootOfTwo => Math.Sqrt(2);

        public static double ReciprocalOfTheRootOfTwo => Math.Sqrt(2) / 2;

        public static double SquareRootOfThree => Math.Sqrt(3);

        public static double ReciprocalOfTheRootOfThree => Math.Sqrt(3) / 2;

        public static double Fi => (1 + Math.Sqrt(5)) / 2;

        public static double ReciprocalOfFi => Fi - 1;
    }
}
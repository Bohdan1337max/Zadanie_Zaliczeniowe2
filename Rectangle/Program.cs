using System;

namespace Rectangle
{
    static class Program
    {
        static void Main(string[] args)
        {
             var ABCD = new Rectangle(3, 4);
             Console.WriteLine(ABCD);
             ABCD.SideA = 5;
             ABCD.Diagonal = 13;
             Console.WriteLine(ABCD);
            
        }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SquareClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            Square square = new Square(10,1,1);
//            Console.WriteLine($"Area: {square.Area}");
//            Console.WriteLine($"Parimeter: {square.Parimeter}");
//            Console.WriteLine($"Surrounded area: \n{square.Edge}");
            
            Cube cube = new Cube(5,5,5,5);
            Console.WriteLine($"Area: {cube.Area}");
            Console.WriteLine($"Parimeter: {cube.Parimeter}");
            Console.WriteLine($"Surrounded area: \n{cube.Edge()}");
        }
    }
}
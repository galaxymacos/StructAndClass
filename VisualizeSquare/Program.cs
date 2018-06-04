using System;

namespace VisualizeSquare
{
    
    internal class Program
    {
        public static char[,] CreateASquareMatrix(int length)
        {
            char[,] matrix = new char[length,length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ' ';
                }
            }

            return matrix;
        }

        public static void DrawALine(Tuple<double,double> startPoint, int endPoint)
        {
            
        }
        
        public static void Main(string[] args)
        {
            var matrix = CreateASquareMatrix(10);
            
        }
    }
}
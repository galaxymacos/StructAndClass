using System;
using System.Text;

namespace ClassVersion
{
    class Rectangle
    {
        public enum Position
        {
            Top,Bottom,Left,Right
        }
        public double Length { get; set; }
        public double Width { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Area => Length * Width;
        public double Parimeter => 2 * (Length * Width);

        public string Edge
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Top left is ({X}, {Y})").Append(new string(' ', 5));
                sb.AppendLine($"Top right is ({X+Width}, {Y})");
                sb.Append($"Bottom left is ({X}, {Y-Length})").Append(new string(' ', 5));
                sb.AppendLine($"Bottom right is ({X+Width}, {Y-Length})");
                return sb.ToString();
            }
        }

        public Rectangle(double length, double width, double x, double y)
        {
            Length = length;
            Width = width;
            X = x;
            Y = y;
        }
        
        public void Move(double amount, Position position)
        {
            switch (position)
            {
                case Position.Bottom:
                    Y -= amount;
                    break;
                case Position.Left:
                    X -= amount;
                    break;
                case Position.Right:
                    X += amount;
                    break;
                case Position.Top:
                    Y += amount;
                    break;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10,10,1,1);
            Console.WriteLine($"Area: {rectangle.Area}");
            Console.WriteLine($"Parimeter: {rectangle.Parimeter}");
            Console.WriteLine($"Occupied space:\n {rectangle.Edge}");
            
            // Moving 
            rectangle.Move(10,Rectangle.Position.Left);
            Console.WriteLine($"Occupied space:\n {rectangle.Edge}");
        }
    }
}
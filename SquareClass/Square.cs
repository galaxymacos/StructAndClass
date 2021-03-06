﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SquareClass
{
    public class Square
    {
        public enum Position
        {
            Right,Left,Bottom,Up
        }
        public double Size { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public virtual double Area => Size * Size;
        public virtual double Parimeter => 4 * Size;
        public List<double> TopLeft => new List<double>{X,Y};
        public List<double> TopRight => new List<double>{X+Size,Y};
        public List<double> BottomLeft => new List<double>{X,Y-Size};
        public List<double> BottomRight => new List<double>{X+Size,Y-Size};
        public virtual List<List<double>> PointPosition => new List<List<double>>{TopLeft,TopRight,BottomLeft,BottomRight};

        public Square(double size, double x, double y)    // x, y should be the top left point
        {
            if(size<0)
                throw new ArgumentOutOfRangeException(nameof(size));
            Size = size;
            X = x;
            Y = y;
        }

        public string Edge()
        {
            StringBuilder sb = new StringBuilder();
            string gap = new string(' ',3);
            int i = 0;
            foreach (List<double> doubles in PointPosition)
            {
                i++;
                sb.Append(doubles.ToPoint()).Append(gap);
                if (i % 2 == 0)
                    sb.AppendLine();
            }
            return sb.ToString();
        }

        public Square Move(double unit, Position position)
        {
            ChangePosition(unit, position);

            return this;
        }

        public virtual void ChangePosition(double unit, Position position)
        {
            switch (position)
            {
                case Position.Bottom:
                    Y -= unit;
                    break;
                case Position.Up:
                    Y += unit;
                    break;
                case Position.Left:
                    X -= unit;
                    break;
                case Position.Right:
                    X += unit;
                    break;
            }
        }
    }
}
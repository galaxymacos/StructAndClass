using System.Collections.Generic;

namespace SquareClass
{
    public class Cube : Square
    {
        public double Z { get; set; }

        public override List<List<double>> PointPosition
        {
            get
            {
                var list = new List<List<double>>();
                foreach (var doubles in base.PointPosition)
                {
                    var doubleFront = new List<double>(doubles);
                    var doubleBack = new List<double>(doubles);
                    doubleFront.Add(Z);
                    doubleBack.Add(Z + Size);
                    list.Add(doubleBack);
                    list.Add(doubleFront);
                }

                return list;
            }
        }

        public Cube(double size, double x, double y, double z) : base(size, x, y)
        {
            Z = z;
        }


        public new enum Position
        {
            Front,
            Back
        }

        public Cube Move(double unit, Position position)
        {
            switch (position)
            {
                case Position.Back:
                    Z += unit;
                    break;
                case Position.Front:
                    Z -= unit;
                    break;
            }

            return this;
        }

        public new Cube Move(double unit, Square.Position position)
        {
            ChangePosition(unit,position);
            return this;
        }


        public override double Area => base.Area * Z;
        public override double Parimeter => 3 * base.Parimeter;
    }
}
using System.Collections.Generic;

namespace SquareClass
{
    public class Cube :Square
    {
        public double Z { get; set; }

        public override List<List<double>> PointPosition
        {
            get
            {
                var list = new List<List<double>>();
                foreach (List<double> doubles in base.PointPosition)
                {
                    var doubleFront = new List<double>(doubles);
                    var doubleBack = new List<double>(doubles);
                    doubleFront.Add(Z);
                    doubleBack.Add(Z+Size);
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

        public double Area => base.Area * Z;
        public double Parimeter => 3 * base.Parimeter;
        public string Edge => base.Edge();
    }
}
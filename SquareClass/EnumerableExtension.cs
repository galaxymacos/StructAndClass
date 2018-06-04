using System.Collections.Generic;
using System.Text;

namespace SquareClass
{
    public static class EnumerableExtension
    {
        public static string ToPoint(this List<double> list)
        {
            StringBuilder sb = new StringBuilder('(');
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if (i != list.Count - 1)
                {
                    sb.Append(',');
                }
            }

            sb.Append(')');
            return sb.ToString();
        }
    }
}
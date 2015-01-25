using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public class DrawingHelper
    {
        public static Point<Int32>[] ValuesToPoints(Point<Double>[] points, Int32 width, Int32 height, Double y1, Double y2)
        {
            Double x1 = points.First().X;
            Double x2 = points.Last().X;
            Point<Int32>[] output = points.Select(p => new Point<Int32>(ValueToPoint(x1, x2, p.X, width),
                                                                        ValueToPoint(y1, y2, p.Y, height)))
                                          .ToArray();
            return output;
        }

        public static Double GetGridStep(Double d)
        {
            Double exp = Math.Floor(Math.Log10(Math.Abs(d)));
            Double basis = d / Math.Pow(10, exp);
            return (basis >= 5 ? 5 : 1) * Math.Pow(10, exp - 1);
        }

        public static Int32 ValueToPoint(Double x1, Double x2, Double x, Int32 H)
        {
            return Convert.ToInt32((x - x1) * H / (x2 - x1));
        }

        public static Double GetGridFirstPoint(Double x1, Double step)
        {
            Double exp = Math.Floor(Math.Log10(Math.Abs(step)));
            Double basis = step / Math.Pow(10, exp);
            Double rest = x1 * Math.Pow(10, exp) % basis;
            return x1 - rest;
        }
    }
}

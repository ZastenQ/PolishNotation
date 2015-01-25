using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluation;

namespace Range_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string func = args[0];
            double x1 = Convert.ToDouble(args[1]);
            double x2 = Convert.ToDouble(args[2]);
            double h = Convert.ToDouble(args[3]);

            Evaluator a = new Evaluator(func);
            List<Point<Double>> points = a.Evaluate(x1, x2, h);
            points.ForEach(z => Console.WriteLine("{0:F2} {1:F4}", z.X, z.Y));
            Console.ReadKey();
        }
    }
}

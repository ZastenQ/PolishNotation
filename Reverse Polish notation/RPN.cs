using Evaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Polish_notation
{
    class RPN
    {
        static void Main(string[] args)
        {
            string inputLine = GetExpression();

            Evaluator evaluator = new Evaluator(inputLine);
            List<string> constants = evaluator.GetConstants();

            Dictionary<string, Double> constantsValues = FillInConst(constants);

            Console.WriteLine("Result: {0:F2}", evaluator.Evaluate(constantsValues));

            Console.ReadKey();
        }

        private static string GetExpression()
        {
            Console.WriteLine("Type expression:");
            string input = null;
            do
            {
                input = Console.ReadLine();
                char[] chars = input.Where(x => x != ' ').ToArray();
                input = new String(chars);
                if (input.Length == 0)
                {
                    Console.WriteLine("Rewrite expression:");
                }

            } while (input.Length == 0);
            return input;
        }

        private static Dictionary<string, double> FillInConst(List<string> constants)
        {
            Dictionary<string, Double> constantsValues = new Dictionary<string, double>();

            foreach (string constant in constants)
            {
                Console.Write("Type value for {0}: ", constant);
                Double valueInt = 0;

                bool isDouble = false;
                do
                {
                    string valueStr = Console.ReadLine();

                    isDouble = Double.TryParse(valueStr, out valueInt);
                    if (!isDouble)
                    {
                        Console.Write("Typed value is not Double type. Type again:");
                    }

                } while (!isDouble);

                constantsValues.Add(constant, valueInt);
            }
            return constantsValues;
        }

    }
}

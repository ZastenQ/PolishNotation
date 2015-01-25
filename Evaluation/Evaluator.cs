using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public class Evaluator
    {
        static private List<BaseOperation> AvailableOperations =
             new List<BaseOperation>() { new Sin(), new Cos(), new Plus(), new Minus(), new Power(), 
                                         new Tan(), new ATan(), new ASin(), new ACos(), new Div(), 
                                         new Sqrt(), new Mult(), new Left(), new Right()};

        public Evaluator(string input)
        {
            List<string> inputList = Split(input);
            originalList = Process(inputList);
        }

        private List<string> originalList;
        private List<string> copyList;

        public double Evaluate(Dictionary<string, double> inputDict)
        {
            copyList = originalList.ToList();

            foreach (KeyValuePair<string, double> constant in inputDict)
            {
                for (int i = 0; i < copyList.Count; i++)
                {
                    if (copyList[i] == constant.Key)
                    {
                        copyList[i] = constant.Value.ToString();
                    }
                }
            }
            return Evaluate();
        }

        public List<Point<Double>> Evaluate(double x1, double x2, double h)
        {
            List<Point<Double>> points = new List<Point<Double>>();

           Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("x", 0);

            for (double i = x1; i < x2; i += h)
            {
                dict["x"] = i;
                double y = Evaluate(dict);
                Point<Double> p = new Point<Double>(i, y);
                points.Add(p);
            }
            return points;
        }

        public List<string> GetConstants()
        {
            return originalList.Where(x => AvailableOperations.All(y => y.Semantic != x) && !IsDouble(x)).Distinct().ToList();
        }


        private double Evaluate()
        {
            if (copyList.Count == 1)
            {
                return Convert.ToDouble(copyList[0]);
            }

            List<BaseOperation> operations = AvailableOperations;
            Int32 index = copyList.FindIndex(inputSymbol => operations.Any(operation => operation.Semantic == inputSymbol));
            // ищем индекс (входной лист) операции или функции по листу доступных операций
            BaseOperation oper = operations.Single(x => x.Semantic == copyList[index]);
            // находим операцию в листе дост. операций по тексту 
            Double[] variables = copyList
                .Skip(index - oper.VariableCount)
                .Take(oper.VariableCount)
                .Select(x => Convert.ToDouble(x))
                .ToArray();
            // отбираем эл-ты во входном листе для калькуляции
            copyList[index] = oper.Calc(variables).ToString();
            for (Int32 i = 0; i < oper.VariableCount; i++)
            {
                copyList.RemoveAt(index - oper.VariableCount);
            }
            return Evaluate();
        }
        
        private List<string> Split(string input)
        {
            bool isNewRow = true;
            List<string> output = new List<string>();

            foreach (char symbol in input.ToCharArray()) //входная строка преобразуется в массив символов
            {
                if (char.IsDigit(symbol) || symbol == '.' || !IsOperand(symbol.ToString())) // статический метод в классе char
                {                                                     // цифра, точка или функция
                    if (isNewRow) // isNewRow == true
                    {
                        output.Add(symbol.ToString());
                        isNewRow = false;
                    }
                    else
                    {
                        output[output.Count - 1] += symbol.ToString();
                    }
                }
                else
                {
                    output.Add(symbol.ToString());
                    isNewRow = true;
                }
            }
            return output;
        }

        private List<string> Process(List<string> inputLines)
        {
            //   string output = "";
            List<string> output = new List<string>();
            Stack<string> stack = new Stack<string>();

            inputLines.ForEach(c =>
            {
                Double outInt = 0;
                if (Double.TryParse(c, out outInt)) // is digit?
                {
                    output.Add(c);
                }
                else if (IsFunction(c))
                {
                    stack.Push(c); // add to stack
                }
                else if (c == "(") // is '('?
                {
                    stack.Push(c); // add to stack
                }
                else if (c == ")") // is ')'?
                {
                    string current;
                    while ((current = stack.Pop()) != "(")
                    {
                        output.Add(current);
                    }

                    while (stack.Count > 0 && IsFunction(stack.Peek()))
                    {
                        output.Add(stack.Pop());
                    }
                }
                else if (IsOperand(c))
                {
                    while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                    {
                        string current = stack.Pop();
                        output.Add(current);
                    }
                    stack.Push(c);
                }
                else
                {
                    output.Add(c); // constants
                }
            });

            while (stack.Count != 0)
            {
                string current = stack.Pop();
                output.Add(current);
            }

            return output;
        }

        private bool IsFunction(string c)
        {
            return AvailableOperations.Any(x => x.Semantic == c && x.Type == OperationType.Function);
        }

        private bool IsOperand(string c)
        {
            return AvailableOperations.Any(x => x.Semantic == c && x.Type == OperationType.Operand);
        }

        private bool IsDouble(string c)
        {
            Double outInt = new Double();
            return Double.TryParse(c, out outInt);
        }

        private Int32 GetPriority(string c)
        {
            return AvailableOperations.Single(x => x.Semantic == c).Priority;
        }
    }

}

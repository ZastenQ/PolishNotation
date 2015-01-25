using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    internal class BaseOperation
    {
        public BaseOperation() { }

        public BaseOperation(string sem, Int32 varCount, OperationType type, Int32 priority)
        {
            Semantic = sem;
            VariableCount = varCount;
            Type = type;
            Priority = priority;
        }

        public String Semantic { get; private set; }   
        public Int32 VariableCount{ get; private set;}
        public OperationType Type { get; private set; }
        public Int32 Priority { get; private set; }


        public virtual Double Calc(Double[] input)
        {
            return 0;
        }
    }

    public enum OperationType
    {
        Function,
        Operand
    }

    class Sin : BaseOperation
    {
        public Sin() : base("sin", 1, OperationType.Function, 0) { } // this is a constructor

        public override Double Calc(Double[] input)
        {
            return Math.Sin(input[0]);
        }

    }

    class Cos : BaseOperation
    {
        public Cos() : base("cos", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Cos(input[0]);
        }
    }

    class Tan : BaseOperation
    {
        public Tan() : base("tan", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Tan(input[0]);
        }
    }

    class ATan : BaseOperation
    {
        public ATan() : base("atan", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Atan(input[0]);
        }
    }

    class ASin : BaseOperation
    {
        public ASin() : base("asin", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Asin(input[0]);
        }
    }

    class ACos : BaseOperation
    {
        public ACos() : base("acos", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Acos(input[0]);
        }
    }

    class Plus : BaseOperation
    {
        public Plus() : base("+", 2, OperationType.Operand, -3) { }

        public override Double Calc(Double[] input)
        {
            return input[0] + input[1];
        }
    }

    class Minus : BaseOperation
    {
        public Minus() : base("-", 2, OperationType.Operand, -3) { }

        public override Double Calc(Double[] input)
        {
            return input[0] - input[1];
        }
    }

    class Power : BaseOperation
    {
        public Power() : base("^", 2, OperationType.Operand, -1) { }

        public override Double Calc(Double[] input)
        {
            return Math.Pow(input[0], input[1]);
        }
    }

    class Mult : BaseOperation
    {
        public Mult() : base("*", 2, OperationType.Operand, -2) { }

        public override Double Calc(Double[] input)
        {
            return input[0] * input[1];
        }
    }

    class Div : BaseOperation
    {
        public Div() : base("/", 2, OperationType.Operand, -2) { }

        public override Double Calc(Double[] input)
        {
            return input[0] / input[1];
        }
    }

    class Sqrt : BaseOperation
    {
        public Sqrt() : base("sqrt", 1, OperationType.Function, 0) { }

        public override Double Calc(Double[] input)
        {
            return Math.Sqrt(input[0]);
        }
    }

    class Left : BaseOperation
    {
        public Left() : base("(", 2, OperationType.Operand, -4) { }

        public override Double Calc(Double[] input)
        {
            return base.Calc(input);
        }
    }
    
    class Right : BaseOperation
    {
        public Right() : base(")", 2, OperationType.Operand, -4) { }

        public override Double Calc(Double[] input)
        {
            return base.Calc(input);
        }
    }
}

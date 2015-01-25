using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public struct Point<T>
    {
        public T X;
        public T Y;

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}

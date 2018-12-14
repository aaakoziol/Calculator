using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("Niedozwolony dzielnik: 0");
            result = NumberA * 1.0 / NumberB;
            return result;
        }
    }
}

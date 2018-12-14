using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationFactory
    {

        public static Operation CreateOperate(EnumOperator op)
        {
            Operation oper = null;
            switch (op)
            {
                case EnumOperator.Add:
                    oper = new OperationAdd();
                    break;
                case EnumOperator.Minus:
                    oper = new OperationMinus();
                    break;
                case EnumOperator.Multiply:
                    oper = new OperationMulti();
                    break;
                case EnumOperator.Divide:
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal class PerformOperationFunc
    {
        public static double PerformOperation(double left, double right, char op)
        {
              (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/': return left / right;
                '%': return left % right;
                case '^': return Math.Pow(left, right);
                default: throw new ArgumentException("Ошибка: " + op);
            }
        }
    }
}

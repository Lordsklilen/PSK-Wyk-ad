﻿using Interpreter.TerminalExpressions;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {


        //    Roman numbers:
        //    I - 1
        //    V - 5
        //    X - 10
        //    L - 50
        //    C - 100
        //    D - 500
        //    M - 1000

        static void Main()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);

            // Wait for user

            Console.ReadKey();
        }
    }
}

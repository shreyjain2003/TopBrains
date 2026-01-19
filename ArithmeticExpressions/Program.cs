using System;

namespace ArithmeticExpressions
{    
    /// <summary>
    /// A simple program to evaluate basic arithmetic expressions.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Evaluates a basic arithmetic expression in the form "a op b".
        /// </summary>
        /// <param name="expression">The arithmetic expression to evaluate, in the form "a op b".</param>
        /// <returns>The result of the arithmetic operation, or an error message if the expression is invalid.</returns>

        public static string Evaluate(string expression)
        {
            if(string.IsNullOrWhiteSpace(expression))
            {
                return "Error:InvalidExpression";
            }

            string[] parts=expression.Split(' ');

            if(parts.Length!=3)
            {
                return "Error:InvalidExpression";
            }

            if(!int.TryParse(parts[0],out int a) || !int.TryParse(parts[2], out int b))
            {
                return "Error:InvalidNumber";
            }

            string op=parts[1];

            switch(op)  // Switch based on the operator
            {
                case "+":
                    return (a+b).ToString();
                case "-":
                    return (a-b).ToString();
                case "*":
                    return (a*b).ToString();
                case "/":
                    if(b==0)
                    return "Error:DivisionByZero";
                return (a/b).ToString();

                default:
                    return "Error:UnknownOperator";
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter expression (a op b): ");
            string expression=Console.ReadLine();
            string result=Evaluate(expression);
            Console.WriteLine(result);
        }        
    }
}
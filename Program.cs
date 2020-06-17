using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: <operation> <number> <number>");
                return;
            }

            string operation = args[0];
            string firstNumberString = args[1];
            string secondNumberString = args[2];

            try
            {
                double result = Calculate(operation, firstNumberString, secondNumberString);
                Console.WriteLine("Result = " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Thank you for using this app :)");
            }
        }

        private static double Calculate(string operation, string firstNumberString, string secondNumberString)
        {
            int firstNumber = Int32.Parse(firstNumberString);
            int secondNumber = Int32.Parse(secondNumberString);
            double result = 0d;
            if (operation == "add")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "substract")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "multiply")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "divide")
            {
                if (secondNumber == 0)
                {
                    throw new DivideByZeroException();
                }

                result = (double) firstNumber / secondNumber;
            }
            else
            {
                throw new Exception("Not acceptable operation!");
            }

            return result;
        }
    }
}
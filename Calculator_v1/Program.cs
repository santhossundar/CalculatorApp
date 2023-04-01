using System;

namespace Calculator_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Menu ------------");
            Console.WriteLine("(+) Addition");
            Console.WriteLine("(-) Subtraction");
            Console.WriteLine("(x) Multiplication");
            Console.WriteLine("(/) divition");
            Console.WriteLine("------------------------------");

            Console.Write("Enter the operation: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Addition();
                    break;
                case "-":
                    Subtraction();
                    break;
                case "*":
                    Multiplication();
                    break;
                case "/":
                    Divition();
                    break;
            }
        }

        public static List<int> getUserInputs(string operation)
        {
            List<int> numbers = new List<int>();

            if (operation == "+" || operation == "-" || operation == "x" || operation == "/")
            {
                int numberInputCount = 0;

                while (true)
                {
                    Console.Write("Enter the number: ");
                    string userInput = Console.ReadLine();

                    if (userInput != "exit")
                    {
                        bool isNumber = Int32.TryParse(userInput, out int number);

                        if (isNumber)
                        {
                            numbers.Add(number);
                        }
                    }
                    else
                    {
                        break;
                    }

                    numberInputCount++;

                    if ((operation == "-" || operation == "/") && numberInputCount > 2)
                    {
                        break;
                    }
                }

                return numbers;
            }
            else
            {
                Console.WriteLine("Invalid operation!");

                return null;
            }   
        }

        public static void Divition()
        {
            throw new NotImplementedException();
        }

        public static void Multiplication()
        {
            throw new NotImplementedException();
        }

        public static void Subtraction()
        {
            throw new NotImplementedException();
        }

        public static void Addition()
        {
            throw new NotImplementedException();
        }
    }
}

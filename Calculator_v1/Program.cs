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
                    Console.WriteLine("Total is " + Addition(getUserInputs(operation)));
                    break;
                case "-":
                    Console.WriteLine("Difference is " + Subtraction(getUserInputs(operation)));
                    break;
                case "x":
                    Console.WriteLine("Multiplied value is " + Multiplication(getUserInputs(operation)));
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

                    if ((operation == "-" || operation == "/") && numberInputCount >= 2)
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

        public static int Multiplication(List<int> numbers)
        {
            int number = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                number *= numbers[i];
            }

            return number;
        }

        public static int Subtraction(List<int> numbers)
        {
            int difference = numbers[0] - numbers[1];

            return difference;
        }

        public static int Addition(List<int> numbers)
        {
            int sum = 0;

            for(int i=0; i<numbers.Count; i++) 
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

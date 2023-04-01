namespace Calculator_v2
{
    public class CommandLineInputForNumbers
    {
        public List<int> getNumbers(string operation)
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
    }
}

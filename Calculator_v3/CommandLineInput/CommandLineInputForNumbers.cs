namespace Calculator_v3.CommandLineInput
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
                        bool isNumber = int.TryParse(userInput, out int number);

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

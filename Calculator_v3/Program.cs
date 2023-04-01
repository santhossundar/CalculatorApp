using Calculator_v3.CommandLineInput;
using Calculator_v3.CommandLineOutput;
using Calculator_v3.Operation;

namespace Calculator_v2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            DisplayMenu displayMenu = new DisplayMenu();
            displayMenu.ShowOperatorSelectionMenu();

            CommandLineInputForOperator inputForOperator = new CommandLineInputForOperator();
            string operation = inputForOperator.getOperator();

            CommandLineInputForNumbers inputForNumbers = new CommandLineInputForNumbers();
            List<int> numbers = inputForNumbers.getNumbers(operation);

            IOperation performOperation = null;

            switch(operation)
            {
                case "+":
                    performOperation = new AddOperation();
                    break;
                case "-":
                    performOperation = new SubtractOperation();
                    break;
                case "x":
                    performOperation = new MultiplyOperation();
                    break;
                case "/":
                    performOperation = new DivideOperation();
                    break;
            }

            double result = performOperation.perform(numbers);

            CommandLineOutput output = new CommandLineOutput();
            output.showResult(result);
        }
    }
}

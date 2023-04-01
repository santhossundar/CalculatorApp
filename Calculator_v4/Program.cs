using Calculator_v4.CommandLineInput;
using Calculator_v4.CommandLineOutput;
using Calculator_v4.Operation;

namespace Calculator_v4
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

            OperationFactory operationFactory = new OperationFactory();
            performOperation = operationFactory.getInstance(operation);

            double result = performOperation.perform(numbers);

            CommandLineOutputForResult outputForResult = new CommandLineOutputForResult();
            outputForResult.showResult(result);
        }
    }
}

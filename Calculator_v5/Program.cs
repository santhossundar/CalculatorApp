using Calculator_v5.CommandLineInput;
using Calculator_v5.CommandLineOutput;
using Calculator_v5.Operation;

namespace Calculator_v5
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

            OperationFactory operationFactory = new OperationFactory();
            IOperation performOperation = operationFactory.getInstance(operation);
            double result = performOperation.perform(numbers);

            CommandLineOutputForResult outputForResult = new CommandLineOutputForResult();
            outputForResult.showResult(result);
        }
    }
}

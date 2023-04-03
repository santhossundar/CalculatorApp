using Calculator_v5.CommandLineInput;
using Calculator_v5.CommandLineOutput;
using Calculator_v5.Operation;

namespace Calculator_v5
{
    internal class Program
    {
        static void Main(String[] args)
        {
            DisplayMenu menu = new DisplayMenu();
            CommandLineInputForOperator inputForOperator = new CommandLineInputForOperator();
            CommandLineInputForNumbers inputForNumbers = new CommandLineInputForNumbers();
            OperationFactory factory = new OperationFactory();
            CommandLineOutputForResult outputForResult = new CommandLineOutputForResult();

            Calculator calculator = new Calculator(
                menu, 
                inputForOperator, 
                inputForNumbers, 
                factory, 
                outputForResult
            );

            calculator.Execute();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            double result = 0;
            switch(operation)
            {
                case "+":
                    AddOperation addOperation = new AddOperation();
                    result = addOperation.perform(numbers);
                    break;
                case "-":
                    SubtractOperation subtractOperation = new SubtractOperation();
                    result = subtractOperation.perform(numbers);
                    break;
                case "x":
                    MultiplyOperation multiplyOperation = new MultiplyOperation();
                    result = multiplyOperation.perform(numbers);
                    break;
                case "/":
                    DivideOperation divideOperation = new DivideOperation();
                    result = divideOperation.perform(numbers);
                    break;
            }

            CommandLineOutput output = new CommandLineOutput();
            output.showResult(result);
        }
    }
}

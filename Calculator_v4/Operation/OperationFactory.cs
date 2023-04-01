using Calculator_v4.Operation;

namespace Calculator_v4.Operation
{
    public class OperationFactory
    {  
        public IOperation getInstance(string operation)
        {
            IOperation performOperation = null;

            switch (operation)
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

            return performOperation;
        }
    }
}

using Calculator_v5.Operation;

namespace Calculator_v5.Operation
{
    public class OperationFactory
    {  
        public IOperation GetInstance(string operation)
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

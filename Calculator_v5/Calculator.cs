using Calculator_v5.CommandLineInput;
using Calculator_v5.CommandLineOutput;
using Calculator_v5.Operation;

namespace Calculator_v5
{
    public class Calculator
    {
        private DisplayMenu menu;
        private CommandLineInputForOperator _operator;
        private CommandLineInputForNumbers numbers;
        private OperationFactory operationFactory;
        private CommandLineOutputForResult result;
        public Calculator(
            DisplayMenu menu,
            CommandLineInputForOperator _operator,
            CommandLineInputForNumbers numbers,
            OperationFactory operationFactory,
            CommandLineOutputForResult result) 
        {
            this.menu = menu;
            this._operator = _operator;
            this.numbers = numbers;
            this.operationFactory = operationFactory;
            this.result = result;
        }

        public void Execute()
        {
            menu.ShowOperatorSelectionMenu();
            string __operator = _operator.GetOperator(); 
            List<int> _numbers = numbers.GetNumbers(__operator);
            IOperation operation = operationFactory.GetInstance(__operator);
            result.showResult(operation.Perform(_numbers));
        }
    }
}

namespace Calculator_v5.CommandLineInput
{
    public class CommandLineInputForOperator
    {
        public string getOperator()
        {
            Console.Write("Enter the operation: ");
            string operation = Console.ReadLine();

            return operation;
        }
    }
}

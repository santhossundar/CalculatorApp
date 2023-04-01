namespace Calculator_v4.CommandLineInput
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

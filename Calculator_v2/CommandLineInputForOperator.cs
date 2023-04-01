namespace Calculator_v2
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

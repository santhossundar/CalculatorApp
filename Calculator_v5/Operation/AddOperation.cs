using Calculator_v5;

namespace Calculator_v5.Operation
{
    public class AddOperation : IOperation
    {
        public float Perform(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

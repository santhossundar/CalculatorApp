using Calculator_v4;

namespace Calculator_v4.Operation
{
    public class AddOperation : IOperation
    {
        public float perform(List<int> numbers)
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

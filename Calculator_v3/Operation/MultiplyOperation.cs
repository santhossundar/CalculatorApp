using Calculator_v2;

namespace Calculator_v3.Operation
{
    public class MultiplyOperation : Operation
    {
        public float perform(List<int> numbers)
        {
            int number = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                number *= numbers[i];
            }

            return number;
        }
    }
}

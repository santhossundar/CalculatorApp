using Calculator_v2;

namespace Calculator_v3.Operation
{
    public class SubtractOperation : IOperation
    {
        public float perform(List<int> numbers)
        {
            int difference = numbers[0] - numbers[1];

            return difference;
        }
    }
}

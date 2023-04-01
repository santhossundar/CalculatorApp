using Calculator_v4;

namespace Calculator_v4.Operation
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

using Calculator_v5;

namespace Calculator_v5.Operation
{
    public class DivideOperation : IOperation
    {
        public float Perform(List<int> numbers)
        {
            float dividedValue = (float)numbers[0] / numbers[1];

            return dividedValue;
        }
    }
}

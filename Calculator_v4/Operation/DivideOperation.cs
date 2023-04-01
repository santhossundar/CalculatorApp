using Calculator_v4;

namespace Calculator_v4.Operation
{
    public class DivideOperation : IOperation
    {
        public float perform(List<int> numbers)
        {
            float dividedValue = (float)numbers[0] / numbers[1];

            return dividedValue;
        }
    }
}

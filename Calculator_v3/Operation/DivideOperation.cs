using Calculator_v2;

namespace Calculator_v3.Operation
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

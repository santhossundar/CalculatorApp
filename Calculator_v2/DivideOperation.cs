namespace Calculator_v2
{
    public class DivideOperation : Operation
    {
        public float perform(List<int> numbers)
        {
            float dividedValue = (float)numbers[0] / numbers[1];

            return dividedValue;
        }
    }
}

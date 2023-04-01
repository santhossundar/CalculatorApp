namespace Calculator_v2
{
    public class AddOperation : Operation
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

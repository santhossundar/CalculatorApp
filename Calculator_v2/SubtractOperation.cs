﻿namespace Calculator_v2
{
    public class SubtractOperation : Operation
    {
        public float perform(List<int> numbers)
        {
            int difference = numbers[0] - numbers[1];

            return difference;
        }
    }
}

﻿using Calculator_v4;

namespace Calculator_v4.Operation
{
    public class MultiplyOperation : IOperation
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

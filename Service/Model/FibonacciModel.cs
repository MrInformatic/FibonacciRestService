using System;

namespace FibonacciRestService.Service.Model
{
    public class FibonacciModel
    {
        public static long Fibonacci(long index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index sould be greater than zero");
            }
            else if (index == 0)
            {
                return 0;
            }
            else
            {
                long previous = 0;
                long current = 1;

                for (long i = 1; i < index; i++)
                {
                    long next = previous + current;
                    previous = current;
                    current = next;
                }

                return current;
            }

        }
    }
}
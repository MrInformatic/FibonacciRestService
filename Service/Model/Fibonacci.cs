using System;

namespace FibonacciRestService.Model
{
    public class Fibonacci
    {
        public static long fibonacci(long index)
        {
            if (index == 0)
            {
                return 0;
            }
            else if (index > 0)
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
            else
            {
                throw new ArgumentException("index sould be greater than zero");
            }
        }
    }
}
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using FibonacciRestService.Service.Model;
using FibonacciRestService.Service;

namespace FibonacciRestService.Tests.Model
{
    public class FibonacciModelTest
    {
        static readonly long[] FIBONACCI_NUMBERS = { 0L, 1L, 1L, 2L, 3L, 5L, 8L, 13L, 21L, 34L, 55L, 89L, 144L };

        [Theory]
        [InlineData(-1L)]
        [InlineData(-2L)]
        [InlineData(-3L)]
        [InlineData(-10L)]
        [InlineData(-100L)]
        public void FibonacciNegativeTest(long index)
        {
            Assert.Throws<ArgumentException>(() => FibonacciModel.Fibonacci(index));
        }

        [Theory]
        [InlineData(0L, 0L)]
        [InlineData(1L, 1L)]
        [InlineData(2L, 1L)]
        [InlineData(3L, 2L)]
        [InlineData(4L, 3L)]
        [InlineData(5L, 5L)]
        [InlineData(6L, 8L)]
        [InlineData(7L, 13L)]
        [InlineData(8L, 21L)]
        [InlineData(9L, 34L)]
        [InlineData(10L, 55L)]
        [InlineData(11L, 89L)]
        [InlineData(12L, 144L)]
        public void FibonacciPositiveTest(long index, long expectedResult)
        {
            Assert.Equal(expectedResult, FibonacciModel.Fibonacci(index));
        }
    }
}

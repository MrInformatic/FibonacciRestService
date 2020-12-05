using System;
using System.Net;
using System.Text.Json;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using FibonacciRestService.Service;

namespace FibonacciRestService.Tests.Controllers
{
    public class FibonacciControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private const string URL_TEMPLATE = "/helloapi/fibonacci/{0}";

        private readonly WebApplicationFactory<Startup> factory;

        public FibonacciControllerTest(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Theory]
        [InlineData(-1L)]
        [InlineData(-2L)]
        [InlineData(-3L)]
        [InlineData(-10L)]
        [InlineData(-100L)]
        public async void FibonacciNegativeIntegartionTest(long index)
        {
            var client = factory.CreateClient();

            var response = await client.GetAsync(String.Format(URL_TEMPLATE, index));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
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
        [InlineData(12L, 100L)]
        [InlineData(13L, 100L)]
        [InlineData(14L, 100L)]
        [InlineData(100L, 100L)]
        [InlineData(1000L, 100L)]
        public async void FibonacciPositiveIntegartionTest(long index, long expectedResult)
        {
            var client = factory.CreateClient();

            var response = await client.GetAsync(String.Format(URL_TEMPLATE, index));

            var contentString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<long>(contentString);

            Assert.Equal(expectedResult, result);
        }
    }
}
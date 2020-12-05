using System;
using Microsoft.AspNetCore.Mvc;
using FibonacciRestService.Service.Model;

namespace FibonacciRestService.Service.Controllers
{
    [ApiController]
    [Route("helloapi/fibonacci")]
    public class FibonacciController : ControllerBase
    {
        [HttpGet]
        [Route("{index}")]
        public IActionResult Fibonacci(long index)
        {
            try
            {
                return new JsonResult(FibonacciModel.Fibonacci(index));
            }
            catch (ArgumentException)
            {
                return new BadRequestResult();
            }
        }
    }
}

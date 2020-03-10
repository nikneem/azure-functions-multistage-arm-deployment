using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace MyDemo.Functions.Functions
{
    public static class HelloWorldFunction
    {
        [FunctionName("HelloWorldFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "hello")]
            HttpRequest req)
        {
            var name = "World";
            return new OkObjectResult($"Hello, {name}");
        }
    }
}
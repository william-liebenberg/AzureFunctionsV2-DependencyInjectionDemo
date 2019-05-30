using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionDemo
{
	public class MethodInjectionDemo
	{
		[FunctionName("methodInjection")]
		public IActionResult Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
			ILogger log,
			ICustomService _svc)
		{
			string message = _svc.GetMessage();
			return new OkObjectResult(message);
		}
	}
}
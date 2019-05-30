using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionDemo
{
	public class ConstructorInjectionDemo
	{
		private readonly ICustomService _svc;

		public ConstructorInjectionDemo(ICustomService svc)
		{
			_svc = svc;
		}

		[FunctionName("ctorInjection")]
		public IActionResult Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
			ILogger log)
		{
			string message = _svc.GetMessage();
			return new OkObjectResult(message);
		}
	}
}

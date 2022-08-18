using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public string Get()
		{
			return ("Ok (1)");
		}
	}
}

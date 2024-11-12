using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RuleOneApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RuleOneController : ControllerBase
	{

		[HttpGet]
		public ActionResult<string> Calculate(int input)
		{
			var result = RuleOneCalculator.Calculate(input);
			return Ok(result);
		}
	}
}

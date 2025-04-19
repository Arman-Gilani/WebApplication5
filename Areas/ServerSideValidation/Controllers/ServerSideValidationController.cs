using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Areas.ServerSideValidation.Controllers
{

	[Area("ServerSideValidation")]
	[Route("ServerSideValidation/ServerSideValidation/{Action}")]

	public class ServerSideValidationController : Controller
	{
		public IActionResult ServerSideValidation()
		{
			return View();
		}
	}
}

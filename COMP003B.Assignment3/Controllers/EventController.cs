using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
	public class EventController : Controller
	{
		// Gets event code
		[HttpGet("event/register/{eventcode}")]

		public IActionResult Register(string eventcode)
		{
			var model = new EventRegistration();

			return View(model);
		}

		[HttpGet("event/register")]

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost("event/register")]

		public IActionResult Register([FromBody] EventRegistration model)
		{
			if (ModelState.IsValid)
			{
				return View("Register", model);
				
			}
			return RedirectToAction("Successful");
		}

		[HttpGet("success")]
		public IActionResult Success(EventRegistration view)
		{
			return View(view);
		}
	}
}

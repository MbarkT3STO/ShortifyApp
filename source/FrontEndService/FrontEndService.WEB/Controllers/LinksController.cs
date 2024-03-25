using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndService.WEB.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LinksController : ControllerBase
{
		[HttpGet(nameof(Redirect)+"/{code}")]
	public async Task<IActionResult> RedirectToOriginalUrl(string code)
	{
		var ipAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
		var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();

		// Redirect the request to localhost:5211/Code/{code}
		return Redirect($"https://localhost:5211/code/{code}?ipAddress={ipAddress}&userAgent={userAgent}");
	}
}

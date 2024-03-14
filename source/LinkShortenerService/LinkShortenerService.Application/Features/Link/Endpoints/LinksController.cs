using LinkShortenerService.Application.Features.Link.Commands;
using LinkShortenerService.Application.Features.Link.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Headers;

namespace LinkShortenerService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LinksController: ControllerBase
{
	readonly IMediator mediator;

	public LinksController(IMediator mediator)
	{
		this.mediator = mediator;
	}


	[HttpGet]
	public async Task<IActionResult> GetLinks()
	{
		var result = await mediator.Send(new GetLinksQuery());

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error);
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetById(int id)
	{
		var result = await mediator.Send(new GetLinkByIdQuery(id));

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}



	[HttpPost(nameof(Create))]
	public async Task<IActionResult> Create([FromBody] CreateLinkCommand command)
	{
		var result = await mediator.Send(command);

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}



	[HttpPut(nameof(Deactivate))]
	public async Task<IActionResult> Deactivate([FromBody] DeactivateLinkCommand command)
	{
		var result = await mediator.Send(command);

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}



	[HttpGet(nameof(Redirect)+"/{code}")]
	public async Task<IActionResult> RedirectToOriginalUrl(string code)
	{
		var ipAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
		var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();

		var query     = new GetLinkByCodeQuery(code, registerClick: true, ipAddress, userAgent);
		var result    = await mediator.Send(query);

		if (result.IsSuccess)
		{
			return Redirect(result.Value.OriginalUrl);
		}

		return BadRequest(result.Error?.Message);
	}
}

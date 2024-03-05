using LinkShortenerService.Application.Features.Link.Commands;
using LinkShortenerService.Application.Features.Link.Queries;
using Microsoft.AspNetCore.Mvc;

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


	[HttpPost]
	public async Task<IActionResult> CreateLink([FromBody] CreateLinkCommand command)
	{
		var result = await mediator.Send(command);

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}
}

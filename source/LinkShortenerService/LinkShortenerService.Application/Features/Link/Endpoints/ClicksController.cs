using LinkShortenerService.Application.Features.Click.Commands;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortenerService.Application.Features.Link.Endpoints;

[ApiController]
[Route("api/[controller]")]
public class ClicksController : ControllerBase
{
	readonly IMediator mediator;

	public ClicksController(IMediator mediator)
	{
		this.mediator = mediator;
	}


	[HttpPost(nameof(Create))]
	public async Task<IActionResult> Create([FromBody] CreateClickCommand command)
	{
		var result = await mediator.Send(command);

		if (result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}
}

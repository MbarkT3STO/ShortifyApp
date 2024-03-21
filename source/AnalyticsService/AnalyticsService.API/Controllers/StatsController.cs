using AnalyticsService.App.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AnalyticsService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatsController : ControllerBase
{
	readonly IMediator _mediator;

	public StatsController(IMediator mediator)
	{
		_mediator = mediator;
	}


	[HttpGet(nameof(GetClicksCountByLinkCode))]
	public async Task<IActionResult> GetClicksCountByLinkCode(string linkCode)
	{
		var query = new GetClicksCountByLinkCodeQuery(linkCode);
		var result = await _mediator.Send(query);

		if(result.IsSuccess)
		{
			return Ok(result.Value);
		}

		return BadRequest(result.Error?.Message);
	}
}

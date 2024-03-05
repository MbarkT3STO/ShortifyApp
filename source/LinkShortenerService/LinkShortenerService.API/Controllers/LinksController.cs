using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShortenerService.Application.Features.Link.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortenerService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LinksController : ControllerBase
{
    readonly IMediator mediator;

	public LinksController(IMediator mediator)
	{
		this.mediator = mediator;
	}


	[HttpGet]
	public async Task<IActionResult> GetLinks()
	{
		var response = await mediator.Send(new GetLinksQuery());
		return Ok(response.Links);
	}
}

using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Shared.Database.Data;
using Shared.Protos.Link;


namespace DatabaseService.Features.Link.Queries;

public class GetLinksQuery : LinkService.LinkServiceBase
{
	private readonly AppDbContext _context;

	public GetLinksQuery(AppDbContext context)
	{
		_context = context;
	}

	public override async Task<GetLinksResponse> GetLinks(GetLinksRequest request, ServerCallContext context)
	{
		var links = await _context.Links.ToListAsync();
		var response = new GetLinksResponse();
		var mappedLinks = links.Select(link => new GetLinksResponseDTO
		{
			Id = link.Id,
			OriginalUrl = link.OriginalUrl,
			ShortUrl = link.ShortUrl
		});

		response.Links.AddRange(mappedLinks);
		return response;
	}
}

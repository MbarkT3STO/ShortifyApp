using Microsoft.EntityFrameworkCore;
using Shared.Database.Data.Entities;

namespace DatabaseService.Services;

public class LinkService(AppDbContext dbContext, IMapper mapper): LinkProtoService.LinkProtoServiceBase
{
	readonly AppDbContext _dbContext = dbContext;
	readonly IMapper _mapper = mapper;


	public override async Task<GetLinksResponse> GetLinks(GetLinksRequest request, ServerCallContext context)
	{
		var links        = await _dbContext.Links.ToListAsync();
		var responseDTOs = _mapper.Map<List<GetLinksResponseDTO>>(links);
		var response     = new GetLinksResponse();
		response.Links.AddRange(responseDTOs);

		return response;
	}

	public override async Task<CreateLinkResponse> CreateLink(CreateLinkRequest request, ServerCallContext context)
	{
		var link = _mapper.Map<Link>(request);


		_dbContext.Links.Add(link);

		await _dbContext.SaveChangesAsync();
		await _dbContext.Entry(link).ReloadAsync();

		var response = new CreateLinkResponse
		{
			Link = _mapper.Map<CreateLinkResponseDTO>(link)
		};

		return response;
	}
}

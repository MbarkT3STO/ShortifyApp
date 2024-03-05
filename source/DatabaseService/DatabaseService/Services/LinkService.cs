using Microsoft.EntityFrameworkCore;

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
}

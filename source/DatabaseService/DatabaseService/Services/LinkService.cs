using Microsoft.EntityFrameworkCore;
using Shared.Database.Data.Entities;

namespace DatabaseService.Services;

public class LinkService(AppDbContext dbContext, IMapper mapper): LinkProtoService.LinkProtoServiceBase
{
	readonly AppDbContext _dbContext = dbContext;
	readonly IMapper _mapper         = mapper;


	public override async Task<GetLinksResponse> GetLinks(GetLinksRequest request, ServerCallContext context)
	{
		var links        = await _dbContext.Links.ToListAsync();
		var responseDTOs = _mapper.Map<List<GetLinksResponseDTO>>(links);
		var response     = new GetLinksResponse();
		response.Links.AddRange(responseDTOs);

		return response;
	}

	public override async Task<GetLinkByIdResponse> GetLinkById(GetLinkByIdRequest request, ServerCallContext context)
	{
		var link = await _dbContext.Links.FindAsync(request.Id);

		if (link == null) throw new RpcException(new Status(StatusCode.NotFound, "Link not found"));

		var responseDTO = _mapper.Map<GetLinkByIdResponseDTO>(link);
		var response    = new GetLinkByIdResponse
		{
			Link = responseDTO
		};

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

	public override async Task<DeactivateLinkResponse> DeactivateLink(DeactivateLinkRequest request, ServerCallContext context)
	{
		var link = await _dbContext.Links.FindAsync(request.Id);

		if (link == null) throw new RpcException(new Status(StatusCode.NotFound, "Link not found"));

		link.IsActive = false;

		await _dbContext.SaveChangesAsync();

		var response      = new DeactivateLinkResponse();
		var responseDTO   = _mapper.Map<DeactivateLinkResponseDTO>(link);

		response.Link = responseDTO;

		return response;
	}
}

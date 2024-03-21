namespace DatabaseService.Services;

public class StatisticsService(AppDbContext dbContext, IMapper mapper): StatisticsProtoService.StatisticsProtoServiceBase
{
	readonly AppDbContext _dbContext = dbContext;
	readonly IMapper _mapper         = mapper;


	public override async Task<GetClicksCountByLinkCodeResponse> GetClicksCountByLinkCode(GetClicksCountByLinkCodeRequest request, ServerCallContext context)
	{
		var link = await _dbContext.Links
			.Where(l => l.ShortUrl.Contains(request.LinkCode))
			.FirstOrDefaultAsync();

		var clicksCount = await _dbContext.Clicks
			.Where(c => c.LinkId == link.Id)
			.CountAsync();

		var response = new GetClicksCountByLinkCodeResponse
		{
			LinkId      = link.Id,
			LinkCode    = request.LinkCode,
			ClicksCount = clicksCount
		};

		return response;
	}
}

using Shared.Protos;

namespace AnalyticsService.App.Queries;

public class GetClicksCountByLinkCodeQueryResultDTO
{
	public int LinkId { get; set; }
	public string LinkCode { get; set; }
	public int ClicksCount { get; set; }
}

public class GetClicksCountByLinkCodeQueryResult: QueryResult<GetClicksCountByLinkCodeQueryResultDTO, GetClicksCountByLinkCodeQueryResult>
{
	public GetClicksCountByLinkCodeQueryResult(GetClicksCountByLinkCodeQueryResultDTO value): base(value)
	{
	}

	public GetClicksCountByLinkCodeQueryResult(Error error): base(error)
	{
	}
}

public class GetClicksCountByLinkCodeQueryMappingProfile: Profile
{
	public GetClicksCountByLinkCodeQueryMappingProfile()
	{
		CreateMap<GetClicksCountByLinkCodeQuery, GetClicksCountByLinkCodeRequest>();
		CreateMap<GetClicksCountByLinkCodeResponse, GetClicksCountByLinkCodeQueryResultDTO>()
			.ForMember(dest => dest.LinkId, opt => opt.MapFrom(src => src.LinkId))
			.ForMember(dest => dest.LinkCode, opt => opt.MapFrom(src => src.LinkCode))
			.ForMember(dest => dest.ClicksCount, opt => opt.MapFrom(src => src.ClicksCount));
	}
}



public class GetClicksCountByLinkCodeQuery: IRequest<GetClicksCountByLinkCodeQueryResult>
{
	public string LinkCode { get; set; }

	public GetClicksCountByLinkCodeQuery(string linkCode)
	{
		LinkCode = linkCode;
	}
}


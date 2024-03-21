using AnalyticsService.App.Base;
using Shared.Database.RPC.Client;
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

		CreateMap<GetClicksCountByLinkCodeResponse, GetClicksCountByLinkCodeQueryResult>()
		.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
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



public class GetClicksCountByLinkCodeQueryHandler : BaseQueryHandler<GetClicksCountByLinkCodeQuery, GetClicksCountByLinkCodeQueryResult>
{
	public GetClicksCountByLinkCodeQueryHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext) : base(mapper, rpcClientContext)
	{
	}


	public override async Task<GetClicksCountByLinkCodeQueryResult> Handle(GetClicksCountByLinkCodeQuery request, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest = _mapper.Map<GetClicksCountByLinkCodeRequest>(request);
			var rpcResponse = await _rpcClientContext.Statistics.GetClicksCountByLinkCodeAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO = _mapper.Map<GetClicksCountByLinkCodeQueryResultDTO>(rpcResponse);

			return GetClicksCountByLinkCodeQueryResult.Succeeded(resultDTO);
		}
		catch (Exception e)
		{
			return GetClicksCountByLinkCodeQueryResult.Failed(e);
		}
	}
}

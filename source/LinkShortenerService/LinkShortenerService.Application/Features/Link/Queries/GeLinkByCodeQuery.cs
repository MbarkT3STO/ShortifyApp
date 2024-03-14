using LinkShortenerService.Application.Features.Click.Commands;

namespace LinkShortenerService.Application.Features.Link.Queries;

public class GetLinkByCodeQueryResultDTO
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }
}

public class GetLinkByCodeQueryResult: QueryResult<GetLinkByCodeQueryResultDTO, GetLinkByCodeQueryResult>
{
	public GetLinkByCodeQueryResult(GetLinkByCodeQueryResultDTO value): base(value)
	{
	}

	public GetLinkByCodeQueryResult(Error error): base(error)
	{
	}
}

public class GeLinkByCodeQueryMappingProfile: Profile
{
	public GeLinkByCodeQueryMappingProfile()
	{
		CreateMap<GetLinkByCodeQuery, GetLinkByCodeRequest>();
		CreateMap<GetLinkByCodeResponse, GetLinkByCodeQueryResultDTO>()
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Link.Id))
			.ForMember(dest => dest.OriginalUrl, opt => opt.MapFrom(src => src.Link.OriginalUrl))
			.ForMember(dest => dest.ShortUrl, opt => opt.MapFrom(src => src.Link.ShortUrl))
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.Link.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.Link.ExpirationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Link.IsActive));

		CreateMap<GetLinkByCodeResponseDTO, GetLinkByCodeQueryResultDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime.ToDateTime()));
	}
}




/// <summary>
/// Represents a query to retrieve a link by its code.
/// </summary>
public class GetLinkByCodeQuery: IRequest<GetLinkByCodeQueryResult>
{
	public string Code { get; set; }
	public bool RegisterClick { get; set; }
	public string IpAddress { get; set; }
	public string UserAgent { get; set; }


	public GetLinkByCodeQuery(string code, bool registerClick = false, string? ipAddress = null, string? userAgent = null)
	{
		Code          = code;
		RegisterClick = registerClick;
		IpAddress     = ipAddress;
		UserAgent     = userAgent;
	}
}


public class GetLinkByCodeQueryHandler(IMapper mapper, IMediator mediator, DatabaseRpcClientContext rpcClientContext) : BaseQueryHandler<GetLinkByCodeQuery, GetLinkByCodeQueryResult>(mapper, mediator, rpcClientContext)
{
    public override async Task<GetLinkByCodeQueryResult> Handle(GetLinkByCodeQuery query, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest  = new GetLinkByCodeRequest { Code = query.Code };
			var rpcResponse = await _rpcClientContext.Links.GetLinkByCodeAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO = _mapper.Map<GetLinkByCodeQueryResultDTO>(rpcResponse);

			var CreateClickCommand = new CreateClickCommand(rpcResponse.Link.Id, query.IpAddress, query.UserAgent);

            _ = _mediator.Send(CreateClickCommand, cancellationToken);

			return GetLinkByCodeQueryResult.Succeeded(resultDTO);
		}
		catch (RpcException e)
		{
			return GetLinkByCodeQueryResult.Failed(e);
		}
		catch (Exception e)
		{
			return GetLinkByCodeQueryResult.Failed(e);
		}
	}
}
using LinkShortenerService.Application.Converters;

namespace LinkShortenerService.Application.Features.Link.Queries;

public class GetLinkByIdQueryResultDTO
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }
}

public class GetLinkByIdQueryResult: QueryResult<GetLinkByIdQueryResultDTO, GetLinkByIdQueryResult>
{
	public GetLinkByIdQueryResult(GetLinkByIdQueryResultDTO value): base(value)
	{
	}

	public GetLinkByIdQueryResult(Error error): base(error)
	{
	}
}

public class GetLinkByIdQueryRpcResponseToDTOConverter: ITypeConverter<GetLinkByIdResponse, GetLinkByIdQueryResultDTO>
{
	public GetLinkByIdQueryResultDTO Convert(GetLinkByIdResponse source, GetLinkByIdQueryResultDTO destination, ResolutionContext context)
	{
		return new GetLinkByIdQueryResultDTO
		{
			Id                    = source.Link.Id,
			OriginalUrl           = source.Link.OriginalUrl,
			ShortUrl              = source.Link.ShortUrl,
			CreationDateAndTime   = source.Link.CreationDateAndTime.ToDateTime(),
			ExpirationDateAndTime = source.Link.ExpirationDateAndTime.ToDateTime(),
			IsActive              = source.Link.IsActive
		};
	}
}

public class GetLinkByIdQueryMappingProfile: Profile
{
	public GetLinkByIdQueryMappingProfile()
	{
		CreateMap<GetLinkByIdQuery, GetLinkByIdRequest>();

		CreateMap<GetLinkByIdResponseDTO, GetLinkByIdQueryResultDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime.ToDateTime()));

		CreateMap<GetLinkByIdResponse, GetLinkByIdQueryResultDTO>()
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Link.Id))
			.ForMember(dest => dest.OriginalUrl, opt => opt.MapFrom(src => src.Link.OriginalUrl))
			.ForMember(dest => dest.ShortUrl, opt => opt.MapFrom(src => src.Link.ShortUrl))
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.Link.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.Link.ExpirationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Link.IsActive));
	}
}



/// <summary>
/// Represents a query to retrieve a link by its ID.
/// </summary>
public class GetLinkByIdQuery: IRequest<GetLinkByIdQueryResult>
{
	public int Id { get; }

	public GetLinkByIdQuery(int id)
	{
		Id = id;
	}
}

public class GetLinkByIdQueryHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext): BaseQueryHandler<GetLinkByIdQuery, GetLinkByIdQueryResult>(mapper, rpcClientContext)
{
	public override async Task<GetLinkByIdQueryResult> Handle(GetLinkByIdQuery query, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest  = new GetLinkByIdRequest { Id = query.Id };
			var rpcResponse = await _rpcClientContext.Links.GetLinkByIdAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO = _mapper.Map<GetLinkByIdQueryResultDTO>(rpcResponse);

			return GetLinkByIdQueryResult.Succeeded(resultDTO);
		}
		catch (RpcException e)
		{
			return GetLinkByIdQueryResult.Failed(e);
		}
		catch (Exception e)
		{
			return GetLinkByIdQueryResult.Failed(e);
		}
	}
}
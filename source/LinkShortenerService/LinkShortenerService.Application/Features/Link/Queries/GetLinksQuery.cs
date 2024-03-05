using AutoMapper;
using Google.Protobuf.Collections;
using Shared.Protos;

namespace LinkShortenerService.Application.Features.Link.Queries;

public class GetLinksQueryResultDTO
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }
}

public class GetLinksQueryResult
{
	public List<GetLinksQueryResultDTO> Links { get; set; }
}

public class GetLinksQueryMappingProfile : Profile
{
	public GetLinksQueryMappingProfile()
	{
		CreateMap<GetLinksResponseDTO, GetLinksQueryResultDTO>();
	}
}

public class GetLinksQuery : IRequest<GetLinksQueryResult>
{
}

public class GetLinksQueryHandler : IRequestHandler<GetLinksQuery, GetLinksQueryResult>
{
	IMapper mapper;

	public GetLinksQueryHandler(IMapper mapper)
	{
		this.mapper = mapper;
	}

	public async Task<GetLinksQueryResult> Handle(GetLinksQuery request, CancellationToken cancellationToken)
	{
		var rpcChannel = GrpcChannel.ForAddress("http://localhost:5256");
		var client = new LinkProtoService.LinkProtoServiceClient(rpcChannel);

		var rpcResponse = await client.GetLinksAsync(new GetLinksRequest(), cancellationToken: cancellationToken);

		var result = new GetLinksQueryResult();
		result.Links = [];

		foreach (var link in rpcResponse.Links)
		{
			var linkDTO = new GetLinksQueryResultDTO
			{
				Id = link.Id,
				OriginalUrl = link.OriginalUrl,
				ShortUrl = link.ShortUrl,
				CreationDateAndTime = link.CreationDateAndTime.ToDateTime(),
				ExpirationDateAndTime = link.ExpirationDateAndTime?.ToDateTime(),
				IsActive = link.IsActive
			};


			result.Links.Add(linkDTO);
		}

		return result;
	}
}
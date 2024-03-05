using AutoMapper;
using Google.Protobuf.Collections;
using LinkShortenerService.Application.Base;
using LinkShortenerService.Application.Common;
using Shared.Database.RPC.Client;
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

public class GetLinksQueryResult : QueryResult<IEnumerable<GetLinksQueryResultDTO>, GetLinksQueryResult>
{
	public GetLinksQueryResult(IEnumerable<GetLinksQueryResultDTO> value) : base(value)
	{
	}

	public GetLinksQueryResult(Error error) : base(error)
	{
	}
}

public class GetLinksQueryMappingProfile: Profile
{
	public GetLinksQueryMappingProfile()
	{
		CreateMap<GetLinksResponseDTO, GetLinksQueryResultDTO>();
	}
}



public class GetLinksQuery: IRequest<GetLinksQueryResult>
{
}

public class GetLinksQueryHandler: BaseQueryHandler<GetLinksQuery, GetLinksQueryResult>
{
	public GetLinksQueryHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext) : base(mapper, rpcClientContext)
	{
	}

	public override async Task<GetLinksQueryResult> Handle(GetLinksQuery request, CancellationToken cancellationToken)
	{
		try
		{
			var rpcResponse = await _rpcClientContext.LinkClient.Client.GetLinksAsync(new GetLinksRequest(), cancellationToken: cancellationToken);
			var resultDTOs = new List<GetLinksQueryResultDTO>();

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

				resultDTOs.Add(linkDTO);
			}

			return GetLinksQueryResult.Succeeded(resultDTOs);
		}
		catch (Exception ex)
		{
			return GetLinksQueryResult.Failed(ex);
		}
	}
}
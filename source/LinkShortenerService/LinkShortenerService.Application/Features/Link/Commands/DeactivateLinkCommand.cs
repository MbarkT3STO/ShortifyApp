using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortenerService.Application.Features.Link.Commands;

public class DeactivateLinkCommandResultDTO
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }
}

public class DeactivateLinkCommandResult: CommandResult<DeactivateLinkCommandResultDTO, DeactivateLinkCommandResult>
{
	public DeactivateLinkCommandResult(DeactivateLinkCommandResultDTO value): base(value)
	{
	}

	public DeactivateLinkCommandResult(Error error): base(error)
	{
	}
}

public class DeactivateLinkCommandMappingProfile: Profile
{
	public DeactivateLinkCommandMappingProfile()
	{
		CreateMap<DeactivateLinkResponseDTO, DeactivateLinkCommandResultDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime.ToDateTime()));

		CreateMap<DeactivateLinkResponse, DeactivateLinkCommandResultDTO>()
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Link.Id))
			.ForMember(dest => dest.OriginalUrl, opt => opt.MapFrom(src => src.Link.OriginalUrl))
			.ForMember(dest => dest.ShortUrl, opt => opt.MapFrom(src => src.Link.ShortUrl))
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.Link.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.Link.ExpirationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Link.IsActive));
	}
}




/// <summary>
/// Represents a command to deactivate a link.
/// </summary>
public class DeactivateLinkCommand: IRequest<DeactivateLinkCommandResult>
{
	public int Id { get; set; }
}


public class DeactivateLinkCommandHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext): BaseCommandHandler<DeactivateLinkCommand, DeactivateLinkCommandResult, DeactivateLinkCommandResultDTO>(mapper, rpcClientContext)
{
	public override async Task<DeactivateLinkCommandResult> Handle(DeactivateLinkCommand request, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest  = new DeactivateLinkRequest { Id = request.Id };
			var rpcResponse = await _rpcClientContext.Links.DeactivateLinkAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO = _mapper.Map<DeactivateLinkCommandResultDTO>(rpcResponse);
			var result    = DeactivateLinkCommandResult.Succeeded(resultDTO);

			return result;
		}
		catch (RpcException e)
		{
			return DeactivateLinkCommandResult.Failed(e);
		}
		catch (Exception e)
		{
			return DeactivateLinkCommandResult.Failed(e);
		}
	}
}

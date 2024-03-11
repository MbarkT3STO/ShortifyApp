namespace LinkShortenerService.Application.Features.Click.Commands;

public class CreateClickCommandResultDTO
{
	public int Id { get; set; }
	public int LinkId { get; set; }
	public DateTime ClickDateTime { get; set; }
	public string IpAddress { get; set; }
	public string UserAgent { get; set; }
}


public class CreateClickCommandResult: CommandResult<CreateClickCommandResultDTO, CreateClickCommandResult>
{
	public CreateClickCommandResult(CreateClickCommandResultDTO value): base(value)
	{
	}

	public CreateClickCommandResult(Error error): base(error)
	{
	}
}

public class CreateClickCommandMappingProfile: Profile
{
	public CreateClickCommandMappingProfile()
	{
		CreateMap<CreateClickCommand, CreateClickRequest>();

		CreateMap<CreateClickResponseDTO, CreateClickCommandResultDTO>()
			.ForMember(dest => dest.ClickDateTime, opt => opt.MapFrom(src => src.ClickDateTime.ToDateTime()));

		CreateMap<CreateClickResponse, CreateClickCommandResultDTO>()
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CreatedClick.Id))
			.ForMember(dest => dest.LinkId, opt => opt.MapFrom(src => src.CreatedClick.LinkId))
			.ForMember(dest => dest.ClickDateTime, opt => opt.MapFrom(src => src.CreatedClick.ClickDateTime.ToDateTime()))
			.ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.CreatedClick.IpAddress))
			.ForMember(dest => dest.UserAgent, opt => opt.MapFrom(src => src.CreatedClick.UserAgent));

	}
}


/// <summary>
/// Represents a command to create a click for a link.
/// </summary>
public class CreateClickCommand: IRequest<CreateClickCommandResult>
{
	public int LinkId { get; set; }
	public string IpAddress { get; set; }
	public string UserAgent { get; set; }
}


public class CreateClickCommandHandler: BaseCommandHandler<CreateClickCommand, CreateClickCommandResult, CreateClickCommandResultDTO>
{
	public CreateClickCommandHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext): base(mapper, rpcClientContext)
	{
	}

	public override async Task<CreateClickCommandResult> Handle(CreateClickCommand command, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest               = _mapper.Map<CreateClickRequest>(command);
				rpcRequest.ClickDateTime = DateTime.UtcNow.ToTimestamp();
			var rpcResponse              = await _rpcClientContext.Clicks.CreateClickAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO                = _mapper.Map<CreateClickCommandResultDTO>(rpcResponse);

			return CreateClickCommandResult.Succeeded(resultDTO);
		}
		catch (Exception ex)
		{
			return CreateClickCommandResult.Failed(ex);
		}
	}
}

namespace LinkShortenerService.Application.Features.Link.Commands;

public class CreateLinkCommandResultDTO
{
	public int Id { get; set; }
	public string OriginalUrl { get; set; }
	public string ShortUrl { get; set; }
	public DateTime CreationDateAndTime { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
	public bool IsActive { get; set; }
}

public class CreateLinkCommandResult: CommandResult<CreateLinkCommandResultDTO, CreateLinkCommandResult>
{
	public CreateLinkCommandResult(CreateLinkCommandResultDTO value): base(value)
	{
	}

	public CreateLinkCommandResult(Error error): base(error)
	{
	}
}

public class CreateLinkCommandMappingProfile: Profile
{
	public CreateLinkCommandMappingProfile()
	{
		CreateMap<CreateLinkCommand, CreateLinkRequest>()
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime != null ? src.ExpirationDateAndTime.Value.ToTimestamp() : null));

		CreateMap<CreateLinkResponse, CreateLinkCommandResultDTO>()
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Link.Id))
			.ForMember(dest => dest.OriginalUrl, opt => opt.MapFrom(src => src.Link.OriginalUrl))
			.ForMember(dest => dest.ShortUrl, opt => opt.MapFrom(src => src.Link.ShortUrl))
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.Link.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.Link.ExpirationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Link.IsActive));

		CreateMap<CreateLinkResponseDTO, CreateLinkCommandResultDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime.ToDateTime()));


	}
}



public class CreateLinkCommand: IRequest<CreateLinkCommandResult>
{
	public string OriginalUrl { get; set; }
	public DateTime? ExpirationDateAndTime { get; set; }
}


public class CreateLinkCommandHandler: BaseCommandHandler<CreateLinkCommand, CreateLinkCommandResult, CreateLinkCommandResultDTO>
{
	public CreateLinkCommandHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext) : base(mapper, rpcClientContext)
	{
	}

	public override async Task<CreateLinkCommandResult> Handle(CreateLinkCommand command, CancellationToken cancellationToken)
	{
		try
		{
			var rpcRequest = _mapper.Map<CreateLinkRequest>(command);

			var (Code, ShortUrl)               = ShortenUrl(command.OriginalUrl);
				rpcRequest.ShortUrl            = ShortUrl;
				rpcRequest.CreationDateAndTime = DateTime.UtcNow.ToTimestamp();
				rpcRequest.IsActive            = true;

			var rpcResponse = await _rpcClientContext.Links.CreateLinkAsync(rpcRequest, cancellationToken: cancellationToken);

			var resultDTO = _mapper.Map<CreateLinkCommandResultDTO>(rpcResponse);

			return CreateLinkCommandResult.Succeeded(resultDTO);
		}
		catch (Exception ex)
		{
			return CreateLinkCommandResult.Failed(ex);
		}
	}

	(string Code, string ShortUrl) ShortenUrl(string url)
	{
		var code     = GenerateShortCode();
		var shortUrl = $"http://localhost:5211/{code}";

		return (code, shortUrl);
	}

	string GenerateShortCode()
	{
		var chars       = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		var stringChars = new char[8];
		var random      = new Random();

		for (int i = 0; i < stringChars.Length; i++)
		{
			stringChars[i] = chars[random.Next(chars.Length)];
		}

		return new string(stringChars);
	}
}
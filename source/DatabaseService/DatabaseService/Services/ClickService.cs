namespace DatabaseService.Services;

public class ClickService(AppDbContext dbContext, IMapper mapper) : ClickProtoService.ClickProtoServiceBase
{
	readonly AppDbContext _dbContext = dbContext;
	readonly IMapper _mapper         = mapper;



	public override async Task<CreateClickResponse> CreateClick(CreateClickRequest request, ServerCallContext context)
	{
		var click = _mapper.Map<Click>(request);

		_dbContext.Clicks.Add(click);

		await _dbContext.SaveChangesAsync();
		await _dbContext.Entry(click).ReloadAsync();

		var responseDTO = _mapper.Map<CreateClickResponseDTO>(click);

		var response = new CreateClickResponse
		{
			CreatedClick = responseDTO
		};

		return response;
	}
}

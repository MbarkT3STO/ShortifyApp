namespace DatabaseService.Mapping;

public class ClickMappingProfile : Profile
{
	public ClickMappingProfile()
	{
		CreateMap<CreateClickRequest, Click>()
			.ForMember(dest => dest.ClickDateTime, opt => opt.MapFrom(src => src.ClickDateTime.ToDateTime()));

		CreateMap<Click, CreateClickResponseDTO>()
			.ForMember(dest => dest.ClickDateTime, opt => opt.MapFrom(src => src.ClickDateTime.ToTimestamp()));
	}
}

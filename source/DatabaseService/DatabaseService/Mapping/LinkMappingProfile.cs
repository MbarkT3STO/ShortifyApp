using Google.Protobuf.WellKnownTypes;
using Shared.Database.Data.Entities;

namespace DatabaseService.Mapping;

public class LinkMappingProfile : Profile
{
	public LinkMappingProfile()
	{
		CreateMap<Link, GetLinksResponseDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToTimestamp()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime != null ? src.ExpirationDateAndTime.Value.ToTimestamp() : null));



		CreateMap<CreateLinkRequest, Link>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToDateTime()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime.ToDateTime()));

		CreateMap<Link, CreateLinkResponseDTO>()
			.ForMember(dest => dest.CreationDateAndTime, opt => opt.MapFrom(src => src.CreationDateAndTime.ToTimestamp()))
			.ForMember(dest => dest.ExpirationDateAndTime, opt => opt.MapFrom(src => src.ExpirationDateAndTime != null ? src.ExpirationDateAndTime.Value.ToTimestamp() : null));


	}
}
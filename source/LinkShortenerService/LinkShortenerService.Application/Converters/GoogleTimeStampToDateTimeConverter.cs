namespace LinkShortenerService.Application.Converters;

public class GoogleTimeStampToDateTimeConverter : ITypeConverter<Timestamp, DateTime>
{
    public DateTime Convert(Timestamp source, DateTime destination, ResolutionContext context)
    {
        return source.ToDateTime();
    }
}

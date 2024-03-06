namespace LinkShortenerService.Application.Converters;

public class GoogleTimestampToDateTimeValueResolver : IValueResolver<Timestamp, DateTime, DateTime>
{
    public DateTime Resolve(Timestamp source, DateTime destination, DateTime destMember, ResolutionContext context)
    {
        return source.ToDateTime();
    }
}

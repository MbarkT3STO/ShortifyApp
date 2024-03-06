namespace LinkShortenerService.Application.Converters;

public class RpcStringToDateTimeConverter : ITypeConverter<string, DateTime>
{
	public DateTime Convert(string source, DateTime destination, ResolutionContext context)
	{
		var timestamp = Timestamp.Parser.ParseJson(source);
		return timestamp.ToDateTime();
	}
}

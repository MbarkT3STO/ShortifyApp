namespace LinkShortenerService.Application.Options;

/// <summary>
/// Represents the connection settings for the RPC service to connect to the database service.
/// </summary>
public class RpcConnectionSettingsForDatabaseService
{
	/// <summary>
	/// Gets or sets the host of the database service.
	/// </summary>
	public string Host { get; set; }

	/// <summary>
	/// Gets or sets the port of the database service.
	/// </summary>
	public int Port { get; set; }

	/// <summary>
	/// Gets the full address of the database service in the format "Host:Port".
	/// </summary>
	public string FullAddress => $"{Host}:{Port}";
}
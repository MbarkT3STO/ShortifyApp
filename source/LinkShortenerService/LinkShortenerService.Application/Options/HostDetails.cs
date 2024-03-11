namespace LinkShortenerService.Application.Options;

/// <summary>
/// Represents the host details for the application.
/// </summary>
public class HostDetails
{
	/// <summary>
	/// Gets or sets the host.
	/// </summary>
	public string Host { get; set; } = "http://localhost";

	/// <summary>
	/// Gets or sets the port.
	/// </summary>
	public int Port { get; set; } = 5211;

	/// <summary>
	/// Gets the host and port combination.
	/// </summary>
	public string HostAndPort => $"{Host}:{Port}";



	public HostDetails()
	{
	}

	public HostDetails(string host, int port)
	{
		Host = host;
		Port = port;
	}
}

using LinkShortenerService.Application.Options;
using Microsoft.Extensions.Options;

namespace LinkShortenerService.Application.RPC;

/// <summary>
/// Provides a gRPC client for the database service.
/// </summary>
public class DatabaseRpcClientProvider : IDisposable, IAsyncDisposable
{
	private readonly GrpcChannel _channel;

	/// <summary>
	/// Gets the gRPC channel used for communication with the database service.
	/// </summary>
	public GrpcChannel Channel => _channel;

	/// <summary>
	/// Gets the RPC connection settings for the database service.
	/// </summary>
	public RpcConnectionSettingsForDatabaseService Settings { get; }


	public DatabaseRpcClientProvider(IOptions<RpcConnectionSettingsForDatabaseService> options)
	{
		Settings = options.Value;
		_channel = GrpcChannel.ForAddress(Settings.FullAddress);
	}






	public void Dispose()
	{
		_channel.ShutdownAsync().Wait();
		_channel.Dispose();
		GC.SuppressFinalize(this);
	}

	public async ValueTask DisposeAsync()
	{
		await _channel.ShutdownAsync();
		_channel.Dispose();
		GC.SuppressFinalize(this);
	}
}

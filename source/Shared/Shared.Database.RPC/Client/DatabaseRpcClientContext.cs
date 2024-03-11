using Grpc.Net.Client;
using Microsoft.Extensions.Options;
using Shared.Database.RPC.Options;
using Shared.Protos;

namespace Shared.Database.RPC.Client;

/// <summary>
/// Provides a gRPC clients for the database service.
/// </summary>
public class DatabaseRpcClientContext: IDisposable, IAsyncDisposable
{
	private readonly GrpcChannel _channel;

	/// <summary>
	/// Gets the gRPC channel used for communication with the database service.
	/// </summary>
	public GrpcChannel Channel => _channel;

	/// <summary>
	/// Gets the RPC connection settings for the database service.
	/// </summary>
	public DatabaseRpcConnectionSettings Settings { get; }

	public RpcClientProvider<LinkProtoService.LinkProtoServiceClient> LinkClient { get; private set; }
	public LinkProtoService.LinkProtoServiceClient Links => LinkClient.Client;

	public RpcClientProvider<ClickProtoService.ClickProtoServiceClient> ClickClient { get; private set; }
	public ClickProtoService.ClickProtoServiceClient Clicks => ClickClient.Client;


	public DatabaseRpcClientContext(IOptions<DatabaseRpcConnectionSettings> options)
	{
		Settings = options.Value;
		_channel = GrpcChannel.ForAddress(Settings.FullAddress);

		InitializeClients();
	}



	private void InitializeClients()
	{
		var linkClient = new LinkProtoService.LinkProtoServiceClient(_channel);
		    LinkClient = new RpcClientProvider<LinkProtoService.LinkProtoServiceClient>(linkClient);

		var clickClient = new ClickProtoService.ClickProtoServiceClient(_channel);
		    ClickClient = new RpcClientProvider<ClickProtoService.ClickProtoServiceClient>(clickClient);
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

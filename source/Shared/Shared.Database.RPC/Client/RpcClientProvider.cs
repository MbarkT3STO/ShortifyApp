namespace Shared.Database.RPC.Client;

/// <summary>
/// Provides a wrapper for an RPC client.
/// </summary>
/// <typeparam name="TClient">The type of the RPC client.</typeparam>
public class RpcClientProvider<TClient>(TClient client)
{
	private readonly TClient _client = client;

	/// <summary>
	/// Gets the <see cref="TClient"/> instance.
	/// </summary>
	public TClient Client => _client;
}

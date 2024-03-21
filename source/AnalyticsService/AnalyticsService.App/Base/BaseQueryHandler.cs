using Shared.Database.RPC.Client;

namespace AnalyticsService.App.Base;

/// <summary>
/// Base class for query handlers that implements IRequestHandler interface.
/// </summary>
/// <typeparam name="TQuery">The type of the query.</typeparam>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public abstract class BaseQueryHandler<TQuery, TResponse>: IRequestHandler<TQuery, TResponse> where TQuery: IRequest<TResponse>
{
	protected readonly IMapper _mapper;
	protected readonly IMediator _mediator;
	protected readonly DatabaseRpcClientContext _rpcClientContext;

	protected BaseQueryHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext)
	{
		_mapper           = mapper;
		_rpcClientContext = rpcClientContext;
	}

	protected BaseQueryHandler(IMapper mapper, IMediator mediator, DatabaseRpcClientContext rpcClientContext)
	{
		_mapper           = mapper;
		_mediator         = mediator;
		_rpcClientContext = rpcClientContext;
	}

	public virtual async Task<TResponse> Handle(TQuery query, CancellationToken cancellationToken)
	{
		return await Task.FromResult(default(TResponse));
	}
}
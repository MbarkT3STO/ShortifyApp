// using Shared.Database.RPC.Client;

// namespace AnalyticsService.App.Base;


// /// <summary>
// /// Represents a base class for command handlers.
// /// </summary>
// /// <typeparam name="TCommand">The type of the command.</typeparam>
// /// <typeparam name="TCommandResult">The type of the command result.</typeparam>
// public abstract class BaseCommandHandler<TCommand, TCommandResult>: IRequestHandler<TCommand, TCommandResult> where TCommand: IRequest<TCommandResult> where TCommandResult: ICommandResult
// {
// 	private protected readonly IMediator _mediator;
// 	private protected readonly IMapper _mapper;


// 	protected BaseCommandHandler(IMapper mapper)
// 	{
// 		_mapper   = mapper;
// 		_mediator = null!;
// 	}

// 	protected BaseCommandHandler(IMediator mediator, IMapper mapper)
// 	{
// 		_mediator = mediator;
// 		_mapper   = mapper;
// 	}

// 	public Task<TCommandResult> Handle(TCommand command, CancellationToken cancellationToken)
// 	{
// 		throw new NotImplementedException();
// 	}
// }



// /// <summary>
// /// Represents a base class for command handlers.
// /// </summary>
// /// <typeparam name="TCommand">The type of the command.</typeparam>
// /// <typeparam name="TCommandResult">The type of the command result.</typeparam>
// /// <typeparam name="TCommandResultValue">The type of the command result value.</typeparam>
// public abstract class BaseCommandHandler<TCommand, TCommandResult, TCommandResultValue>: IRequestHandler<TCommand, TCommandResult> where TCommand: IRequest<TCommandResult> where TCommandResult: ICommandResult<TCommandResultValue>
// {
// 	private protected readonly IMediator _mediator;
// 	private protected readonly IMapper _mapper;
// 	private protected readonly DatabaseRpcClientContext _rpcClientContext;


// 	protected BaseCommandHandler(IMapper mapper)
// 	{
// 		_mapper   = mapper;
// 		_mediator = null!;
// 	}


// 	protected BaseCommandHandler(IMapper mapper, DatabaseRpcClientContext rpcClientContext)
// 	{
// 		_mapper           = mapper;
// 		_rpcClientContext = rpcClientContext;
// 		_mediator         = null!;
// 	}


// 	protected BaseCommandHandler(IMediator mediator, IMapper mapper)
// 	{
// 		_mediator = mediator;
// 		_mapper   = mapper;
// 	}


// 	public virtual Task<TCommandResult> Handle(TCommand command, CancellationToken cancellationToken)
// 	{
// 		throw new NotImplementedException();
// 	}
// }
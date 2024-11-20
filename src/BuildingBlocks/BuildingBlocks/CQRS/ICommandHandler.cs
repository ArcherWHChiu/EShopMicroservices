using MediatR;

namespace BuildingBlocks.CQRS;

// Command with no return body
public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit> 
    where TCommand : ICommand<Unit>
{

}

// Command with not empty body
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> 
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
    
}
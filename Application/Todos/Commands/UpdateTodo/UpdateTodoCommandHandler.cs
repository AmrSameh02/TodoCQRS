using Application.Common.Interfaces;
using MediatR;
using Domain.Todos;
using Application.Common.Exceptions;

namespace Application.Todos.Commands.UpdateTodo
{
	public class UpdateTodoCommandHandler(IAppDbContext context) : IRequestHandler<UpdateTodoCommand>
	{
		public async Task Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
		{
			var todo = await context.Todos.FindAsync([request.Id], cancellationToken);
			if (todo is null)
				throw new NotFoundException(nameof(Todo), request.Id);

			todo.Title = request.title;
			todo.Completed = request.completed;

			await context.SaveChangesAsync(cancellationToken);
		}
	}
}

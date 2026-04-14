using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Commands.DeleteTodo
{
	public sealed class DeleteTodoCommandHandler(IAppDbContext context) : IRequestHandler<DeleteTodoCommand>
	{
		public async Task Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
		{
			var todo = await context.Todos.FindAsync([request.id],cancellationToken);

			if (todo is null)
				throw new NotFoundException(nameof(Todo), request.id);


			context.Todos.Remove(todo);
			await context.SaveChangesAsync(cancellationToken);

		}
	}
}

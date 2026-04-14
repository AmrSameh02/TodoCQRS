using Application.Common.Interfaces;
using Domain.Todos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Queries.GetTodos
{
	public sealed class GetTodoByIdQueryHandler(IAppDbContext context) : IRequestHandler<GetTodosQuery, List<Todo>>
	{
		public async Task<List<Todo>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
		{
			return await context.Todos.ToListAsync(cancellationToken);

		}
	}
}

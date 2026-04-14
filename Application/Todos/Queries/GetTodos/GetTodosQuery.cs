using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Queries.GetTodos
{
	public sealed record GetTodosQuery : IRequest<List<Todo>>;

}

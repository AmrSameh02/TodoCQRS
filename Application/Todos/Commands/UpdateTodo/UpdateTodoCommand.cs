using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Commands.UpdateTodo
{
	public sealed record UpdateTodoCommand(Guid Id,string title, bool completed) : IRequest;
	
}

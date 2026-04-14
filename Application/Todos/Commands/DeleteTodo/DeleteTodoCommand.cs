using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Commands.DeleteTodo
{
	public sealed record DeleteTodoCommand(Guid id) : IRequest; 
	
}

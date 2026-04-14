using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Todos.Commands.CreateTodo
{
	public class CreateTodoCommandValidator: AbstractValidator<CreateTodoCommand>
	{
		public CreateTodoCommandValidator()
		{
			RuleFor(x => x.title).NotEmpty().WithMessage("Title Should not be empty");

		}
	}
}

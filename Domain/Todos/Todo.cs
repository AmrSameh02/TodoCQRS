using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Todos
{
	public class Todo
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = default!;
		public bool Completed { get; set; }

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
	public class NotFoundException(string entity, Guid id) : Exception($"the {entity} with id: '{id}' not found");
	
}

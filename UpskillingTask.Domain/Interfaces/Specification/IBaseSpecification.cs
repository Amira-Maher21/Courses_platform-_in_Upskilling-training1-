using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Interfaces.Specification
{
	public interface IBaseSpecification<T>
	{

		Expression<Func<T, bool>> Criteria { get; }
		List<Expression<Func<T, bool>>> Filters { get; }
		List<Expression<Func<T, object>>> Includes { get; }
		List<string> IncludeStrings { get; }
		Expression<Func<T, object>> OrderBy { get; }
		Expression<Func<T, object>> OrderByDescending { get; }
		Expression<Func<T, object>> GroupBy { get; }
	}
}

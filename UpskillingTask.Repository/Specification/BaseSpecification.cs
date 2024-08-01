using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UpskillingTask.Domain.Interfaces.Specification;

namespace UpskillingTask.Repository.Specification
{
	public class BaseSpecification<T> : IBaseSpecification<T>
	{
		public Expression<Func<T, bool>> Criteria{  get;  }

		public List<Expression<Func<T, bool>>> Filters => throw new NotImplementedException();

		public List<Expression<Func<T, object>>> Includes => throw new NotImplementedException();

		public List<string> IncludeStrings => throw new NotImplementedException();

		public Expression<Func<T, object>> OrderBy => throw new NotImplementedException();

		public Expression<Func<T, object>> OrderByDescending => throw new NotImplementedException();

		public Expression<Func<T, object>> GroupBy => throw new NotImplementedException();

		protected BaseSpecification(Expression<Func<T, bool>> criteria)
		{
			//aCriteria = criteria;
		}
		protected BaseSpecification()
		{

		}
	}
}

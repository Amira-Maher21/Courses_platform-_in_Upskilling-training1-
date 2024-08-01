using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UpskillingTask.Domain.Interfaces.Specification;

namespace UpskillingTask.Domain.Interfaces
{
	public interface IBaseRepository<T,S> where T : class where S : class
	{

		Task<S> GetByIDAsync(int id);
		Task<List<S>> GetAllAsync(Expression<Func<T, bool>>? predict, IBaseSpecification<T> specification = null);
		Task<bool> IsExists(Expression<Func<T, bool>> predict);
		S DeleteAsync(S entity);
		Task<S> UpdateAsync(S entity, bool Save = false);
		Task<T> CreateAsync(S entity, bool Save = true);
		List<S> DeleteAllAsync(List<S> entities);
		Task<S> GetOneAsync(Expression<Func<T, bool>> predict, IBaseSpecification<T> specification = null);

		Task<int> GetCountAsync(IBaseSpecification<T> specification = null);
	}
}

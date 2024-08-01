using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UpskillingTask.Domain.Interfaces;
using UpskillingTask.Domain.Interfaces.Specification;

namespace UpskillingTask.Repository.Repositories
{
	public class BaseRepository<T, S> : IBaseRepository<T, S> where T : class where S : class
	{
		//protected readonly TraofDbContext _dbContext;
		private readonly IMapper _mapper;

		public BaseRepository( IMapper mapper) //TraofDbContext dbContext
		{
			//_dbContext = dbContext;
			_mapper = mapper;
		}

		public Task<T> CreateAsync(S entity, bool Save = true)
		{
			//T entity = _mapper.Map<T>(dto);
			//await _dbContext.Set<T>().AddAsync(entity);
			//if (Save)
			//{
			//	await _dbContext.SaveChangesAsync();
			//}
			//return entity;

			throw new NotImplementedException();
		}

		public List<S> DeleteAllAsync(List<S> entities)
		{
			throw new NotImplementedException();
		}

		public S DeleteAsync(S entity)
		{
			throw new NotImplementedException();
		}

		public Task<List<S>> GetAllAsync(Expression<Func<T, bool>>? predict, IBaseSpecification<T> specification = null)
		{
			throw new NotImplementedException();
		}

		public Task<S> GetByIDAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<int> GetCountAsync(IBaseSpecification<T> specification = null)
		{
			throw new NotImplementedException();
		}

		public Task<S> GetOneAsync(Expression<Func<T, bool>> predict, IBaseSpecification<T> specification = null)
		{
			throw new NotImplementedException();
		}

		public Task<bool> IsExists(Expression<Func<T, bool>> predict)
		{
			throw new NotImplementedException();
		}

		public Task<S> UpdateAsync(S entity, bool Save = false)
		{
			throw new NotImplementedException();
		}
	}
}

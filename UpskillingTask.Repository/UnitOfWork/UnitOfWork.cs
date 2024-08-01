using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpskillingTask.Domain.Interfaces;

namespace UpskillingTask.Repository.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		//private readonly TraofDbContext _context;
		//private Hashtable _repositories;
		//private Hashtable _Plainrepositories;
		//private readonly IMapper _mapper;

		//public UnitOfWork(TraofDbContext context, IMapper mapper)
		//{
		//	_context = context;
		//	_mapper = mapper;
		//	TrackRepo = new TrackRepository(_context);
		//}


		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IBaseRepository<TEntity, SDto> Repository<TEntity, SDto>()
			where TEntity : class
			where SDto : class
		{
			throw new NotImplementedException();
		}

		public Task<int> SaveAsync()
		{
			throw new NotImplementedException();
		}
	}
}


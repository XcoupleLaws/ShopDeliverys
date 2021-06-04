using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public abstract class GenericRepository<TEntity> : IRepository<TEntity,int>
		where TEntity : class, IEntity

	{
		protected readonly ShopContext _dataContext;
		protected readonly DbSet<TEntity> _dataTable;


		protected GenericRepository(ShopContext dataContext, DbSet<TEntity> dataTable)
		{

			_dataTable = dataTable;
			_dataContext = dataContext;
		}

		public virtual void Delete(TEntity entity)
		{
			_dataContext.Entry(entity).State = EntityState.Unchanged;
			_dataTable.Attach(entity);

			_dataTable.Remove(entity);
		}

		public virtual List<TEntity> GetAll() => _dataTable.ToList();


		public virtual TEntity GetById(int id) =>
			_dataTable.Find(id);
		
		public virtual void Add(TEntity obj) {
			_dataTable.Add(obj);
			_dataContext.SaveChanges();
		}

		public virtual void Update(TEntity obj)
		{
			TEntity entity = _dataTable.Find(obj.Id);
			_dataContext.Entry(entity)?.CurrentValues.SetValues(obj);
			_dataContext.SaveChanges();
		}
	}
}
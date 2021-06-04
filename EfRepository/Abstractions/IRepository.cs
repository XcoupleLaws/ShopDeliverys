using System.Collections.Generic;

namespace EfRepository.Abstractions
{
    public interface IRepository<TEntity,TKey>
    {
        void Add(TEntity obj);
        List<TEntity> GetAll();

        TEntity GetById(TKey id);
        
        void Delete(TEntity obj);
        void Update(TEntity obj);
    }
}
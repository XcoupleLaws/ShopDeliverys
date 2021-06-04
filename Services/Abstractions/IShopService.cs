using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IService<TModel>
    {
        void Add(TModel item);

        TModel Get(int id);

        List<TModel> GetAll();

        void Delete(TModel item);
    }
}
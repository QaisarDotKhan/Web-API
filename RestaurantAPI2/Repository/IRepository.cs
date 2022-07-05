using System;
using System.Collections.Generic;

namespace RestaurantAPI2.Repository
{
    public interface IRepository<T>
    {
        ICollection<T> GetAll();

        T Get(int id);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        T GetById(int id);
    }
}

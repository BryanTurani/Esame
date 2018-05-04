using System.Collections.Generic;

namespace AssociazioneSportiva.DataAccess
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T Find(int id);
        void Update(T model);
        void Insert(T model);
        bool Delete(T model);
    }
}

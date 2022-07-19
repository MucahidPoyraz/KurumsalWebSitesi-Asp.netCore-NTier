using Kemer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kemer.Dal.Abstract
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {

        List<T> HepsiniGetirDal();
        List<T> HepsiniGetirDal(Expression<Func<T, bool>> filter);
        Task<List<T>> HepsiniGetirDal<TKey>(string p,Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrdeyByType ordeyByType = OrdeyByType.DESC);
        List<T> BaglıTablolarIleGetirDal(string p);
        T IdileGetirDal(Expression<Func<T, bool>> filter);
        

        void EkleDal(T p);
        void GuncelleDal(T p);
        void SilDal(T p);




    }

    public enum OrdeyByType
    {
        ASC = 1,
        DESC = 2
    }
}

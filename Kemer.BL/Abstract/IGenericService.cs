using Kemer.Entities.Abstract;
using System.Collections.Generic;

namespace Kemer.BL.Abstract
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        List<T> HepsiniGetirBl();
        List<T> HepsiniGetirBl(string p);



        T IdileGetirBl(int id);

        void SilBl(int id);
        void GuncelleBl(T p);
        void EkleBl(T p);
    }
}

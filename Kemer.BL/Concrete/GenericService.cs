using Kemer.BL.Abstract;
using Kemer.Dal.Abstract;
using Kemer.Entities.Abstract;
using System.Collections.Generic;

namespace Kemer.BL.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class, IEntity, new()
    {
        private readonly IGenericRepository<T> _repository;


        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;

        }

        public void EkleBl(T p)
        {

            _repository.EkleDal(p);


        }

        public void GuncelleBl(T p)
        {

            _repository.GuncelleDal(p);


        }

        public List<T> HepsiniGetirBl()
        {
            return _repository.HepsiniGetirDal();
        }



        public List<T> HepsiniGetirBl(string p)
        {
            return _repository.BaglıTablolarIleGetirDal(p);
        }



        public T IdileGetirBl(int id)
        {
            return _repository.IdileGetirDal(x => x.Id == id);
        }

        public void SilBl(int id)
        {
            var silinecek = IdileGetirBl(id);
            _repository.SilDal(silinecek);
        }
    }
}

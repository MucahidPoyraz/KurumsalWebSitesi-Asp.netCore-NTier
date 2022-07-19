using Kemer.BL.Abstract;
using Kemer.Dal.Abstract;
using Kemer.Entities.Concrete;
using System.Collections.Generic;

namespace Kemer.BL.Concrete
{
    public class ServiceContentService : GenericService<ServiceContent>, IServiceContentService
    {
        private readonly IGenericRepository<ServiceContent> _servicecontent;

        public ServiceContentService(IGenericRepository<ServiceContent> repository, IGenericRepository<ServiceContent> servicecontent) : base(repository)
        {
            _servicecontent = servicecontent;
        }

        public List<ServiceContent> DetaylarıGetirBl(int id)
        {
            return _servicecontent.HepsiniGetirDal(x => x.ServiceId == id);
        }
    }
}

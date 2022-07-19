using Kemer.Entities.Concrete;
using System.Collections.Generic;

namespace Kemer.BL.Abstract
{
    public interface IServiceContentService : IGenericService<ServiceContent>
    {
        List<ServiceContent> DetaylarıGetirBl(int id);
    }
}

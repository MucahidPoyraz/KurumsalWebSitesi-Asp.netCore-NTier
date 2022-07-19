using Kemer.Entities.Concrete;
using System.Collections.Generic;

namespace Kemer.BL.Abstract
{
    public interface IProductSliderService : IGenericService<ProductSlider>
    {
        List<ProductSlider> DetaylarıGetirBl(int id);
    }
}

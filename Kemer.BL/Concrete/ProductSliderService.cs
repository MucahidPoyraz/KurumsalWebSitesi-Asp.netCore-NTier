using Kemer.BL.Abstract;
using Kemer.Dal.Abstract;
using Kemer.Entities.Concrete;
using System.Collections.Generic;

namespace Kemer.BL.Concrete
{
    public class ProductSliderService : GenericService<ProductSlider>, IProductSliderService
    {

        private readonly IGenericRepository<ProductSlider> _productservice;


        public ProductSliderService(IGenericRepository<ProductSlider> repository, IGenericRepository<ProductSlider> productservice) : base(repository)
        {
            _productservice = productservice;
        }

        public List<ProductSlider> DetaylarıGetirBl(int id)
        {
            return _productservice.HepsiniGetirDal(x => x.ProductId == id);
        }
    }
}

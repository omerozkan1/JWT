using JsonWebToken.Business.Interfaces;
using JsonWebToken.DataAccess.Interfaces;
using JsonWebToken.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Business.Concrate
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IGenericDal<Product> genericDal,
            IProductDal productDal) : base(genericDal)
        {
            _productDal = productDal;
        }



    }
}

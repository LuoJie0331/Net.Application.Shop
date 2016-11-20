using Net.Application.Shop.Core;
using Net.Framework.Entity.Repository;
using Net.General.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Net.Application.Shop.Controllers
{
    public class ProductSellController : ApiController
    {
        IRepository<ProductSell> sellRepository = IocManager.Resolve<IRepository<ProductSell>>();

        public ProductSell Get(int id)
        {
            return sellRepository.Find(id);
        }

        public object Get(int page, int size)
        {
            int total = 0;
            var list = sellRepository.Page(page, size, out total);
            return new
            {
                page = page,
                total = total,
                list = list
            };
        }
    }
}

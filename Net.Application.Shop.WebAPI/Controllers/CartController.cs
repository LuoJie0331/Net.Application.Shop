using Net.Application.Shop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Net.Application.Shop.Controllers
{
    public class CartController : ApiController
    {
        int uid = 1;

        public List<OrderItem> Get()
        {
            Cart cart = new Cart(uid);

            return cart.Items;
        }

        public List<OrderItem> Put(int sellid, int count)
        {
            Cart cart = new Cart(uid);
            OrderItem item = new OrderItem()
            {
                SellID = sellid,
                Count = count
            };

            return cart.Items;
        }

        public List<OrderItem> PostCheck(int[] list)
        {
            Cart cart = new Cart(uid);
            cart.CheckItems(list);

            return cart.Items;
        }
    }
}

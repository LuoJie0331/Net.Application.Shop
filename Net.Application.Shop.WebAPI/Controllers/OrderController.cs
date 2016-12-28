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
    public class OrderController : ApiController
    {
        IRepository<OrderItem> orderitemRepository = IocManager.Resolve<IRepository<OrderItem>>();
        IRepository<Order> orderRepository = IocManager.Resolve<IRepository<Order>>();

        //public Order Put(int[] items)
        //{
        //    Order order = new Order();

        //    order.UserID = 1;
        //    order.OrderStatus = OrderStatus.待支付;
        //    var item_list = new List<OrderItem>();
        //    foreach (var itemID in items)
        //    {
        //        var item = orderitemRepository.Find(itemID);
        //        item_list.Add(item);
        //    }
        //    order.TotalCost = order.CountTotalCost();

        //    return order;
        //}
        public Order Put([FromBody]string poster, [FromBody]string address, [FromBody]string tel, [FromBody]string receiver)
        {
            int uid = 1;

            Order order = new Order();
            Cart cart = new Cart(uid);

            order.Items.AddRange(cart.Items.Where(c => c.CheckForOrder));
            foreach (var item in order.Items)
            {
                item.OrderItemStatus = OrderItemStatus.InOrder;
            }
            order.PostFee = 10;
            order.CountTotalCost();
            order.PostCompany = poster;
            order.PostAddress = address;
            order.PostReceiver = receiver;
            order.PostTel = tel;
            orderRepository.Add(order);

            return order;
        }

        public Order Get()
        {
            int uid = 1;

            Order order = new Order();
            Cart cart = new Cart(uid);

            order.Items.AddRange(cart.Items.Where(c => c.CheckForOrder));
            order.PostFee = 10;
            order.CountTotalCost();

            return order;
        }
    }
}

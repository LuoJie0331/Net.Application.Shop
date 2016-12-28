using Net.Framework.Entity.Repository;
using Net.General.Dependency;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop.Core
{
    public class Cart
    {
        IRepository<OrderItem> orderitemRepository = IocManager.Resolve<IRepository<OrderItem>>();
        private int uid;

        public List<OrderItem> Items { get; private set; }

        public Cart(int uid)
        {
            this.uid = uid;
            LoadCart();
        }

        public void LoadCart()
        {
            this.Items = orderitemRepository.List(c => c.UserID == this.uid && c.OrderItemStatus == OrderItemStatus.InCart);
        }

        public void AddItem(OrderItem item)
        {
            item.UserID = this.uid;
            item.OrderItemStatus = OrderItemStatus.InCart;
            orderitemRepository.Add(item);

            this.Items.Add(item);
        }

        public void RemoveItem(int id)
        {
            foreach (var item in this.Items)
            {
                if (item.ID == id)
                {
                    orderitemRepository.Real_Delete(id);
                    this.Items.Remove(item);
                    break;
                }
            }
        }

        public void CheckItems(int[] list)
        {
            foreach (var item in this.Items)
            {
                item.CheckForOrder = list.Contains(item.ID);
            }

            orderitemRepository.SaveChanges();
        }

        public int TotalCost()
        {
            int total = 0;
            foreach (var item in this.Items)
            {
                total += item.Cost();
            }

            return total;
        }
    }
}

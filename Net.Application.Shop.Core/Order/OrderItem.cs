using Net.Framework.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop.Core
{
    [Table("OrderItem")]
    public class OrderItem : ModelBase
    {
        #region 字段
        [Key]
        public int ID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public int SellID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Count { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        #endregion

        #region 方法

        public int TotalCost()
        {
            return this.Price * this.Count;
        }

        #endregion
    }
}

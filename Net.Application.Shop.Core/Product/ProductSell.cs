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
    [Table("ProductSell")]
    public class ProductSell : ModelBase
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required, MaxLength(1024)]
        public string SellTitle { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}

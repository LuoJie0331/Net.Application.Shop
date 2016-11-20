using Net.Framework.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop.Core
{
    public class Category : ModelBase
    {
        public Category()
        {
            this.Sells = new List<ProductSell>();
        }

        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public virtual List<ProductSell> Sells { get; set; }
    }
}

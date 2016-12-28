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
    [Table("Product")]
    public class Product : ModelBase
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(1024)]
        public string Name { get; set; }

        [Required, MaxLength(256)]
        public string Brand { get; set; }

        public int Price { get; set; }

        //public List<string> Photos { get; set; }

        public string Introduce { get; set; }
    }
}

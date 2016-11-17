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

        public string Name { get; set; }
    }
}

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
    [Table("UserAddress")]
    public class UserAddress : ModelBase
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public int UserID { get; set; }

        [Required, MaxLength(20)]
        public string Province { get; set; }

        [Required, MaxLength(20)]
        public string City { get; set; }

        [Required, MaxLength(512)]
        public string Address { get; set; }

        [Required, MaxLength(64)]
        public string ReceiverName { get; set; }

        [Required, MaxLength(128)]
        public string ReceiverTel { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}

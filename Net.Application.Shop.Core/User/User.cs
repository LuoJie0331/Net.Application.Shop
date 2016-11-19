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
    [Table("User")]
    public class User : ModelBase
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        [Display(Name = "用户名")]
        public String Name { get; set; }

        [MaxLength(20)]
        [Display(Name = "昵称")]
        public String NickName { get; set; }

        [MaxLength(100)]
        [Display(Name = "OpenID")]
        public string OpenID { get; set; }

        [MaxLength(20)]
        [Display(Name = "手机号码")]
        public string Mobile { get; set; }

        [MaxLength(20)]
        [Display(Name = "身份证号")]
        public string IdentityNo { get; set; }

        [Display(Name = "性别")]
        public Sex Sex { get; set; }

        [MaxLength(20)]
        [Display(Name = "城市")]
        public string City { get; set; }

        [MaxLength(50)]
        [Display(Name = "国家")]
        public string Country { get; set; }

        [MaxLength(20)]
        [Display(Name = "省份")]
        public string Province { get; set; }

        [MaxLength(500)]
        [Display(Name = "头像")]
        public string HeadImgUrl { get; set; }

        public Subscribe Subscribe { get; set; }
    }

    public enum Sex
    {
        未知 = 0,
        男 = 1,
        女 = 2
    }

    public enum Subscribe
    {
        未知 = -1,
        未关注 = 0,
        已关注 = 1
    }
}

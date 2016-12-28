using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop.Models
{
    public class PageResult<T>
    {
        public int Index { get; set; }
        public int Total { get; set; }
        public List<T> List { get; set; }
    }
}

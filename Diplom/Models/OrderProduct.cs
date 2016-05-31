using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class OrderProduct
    {
        public int orderProductID { set; get; }
        [Required]
        public int orderID { set; get; }
        [Required]
        public int productID { set; get; }
        [Required]
        public int count { set; get; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

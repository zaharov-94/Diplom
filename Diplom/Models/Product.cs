using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Product
    {
        public int productID { set; get; }
        [Required]
        [MaxLength(15)]
        public string name { set; get; }
        [MaxLength(50)]
        public string description { set; get; }
        [MaxLength(10)]
        public string unit { set; get; }
        [Required]
        public decimal price { set; get; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<SupplyProduct> SupplyProducts { get; set; }
    }
}

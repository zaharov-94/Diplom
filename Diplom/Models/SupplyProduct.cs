using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class SupplyProduct
    {
        public int supplyProductID { set; get; }
        [Required]
        public int supplyID { set; get; }
        [Required]
        public int productID { set; get; }
        [Required]
        public int count { set; get; }

        public virtual Supply Supply { get; set; }
        public virtual Product Product { get; set; }
    }
}

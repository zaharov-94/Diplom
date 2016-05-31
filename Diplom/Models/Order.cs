using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Order
    {
        public int orderID { set; get; }
        [Required]
        public int employeeID { set; get; }
        [Required]
        public DateTime date { set; get; }
        [Required]
        public int clientID { set; get; }

        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        
    }
}

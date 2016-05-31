using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Supply
    {
        public int supplyID { set; get; }
        [Required]
        public int employeeID { set; get; }
        [Required]
        public DateTime date { set; get; }
        [Required]
        public int providerID { set; get; }

        public virtual ICollection<SupplyProduct> SupplyProducts { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Provider Provider { get; set; }
    }
}

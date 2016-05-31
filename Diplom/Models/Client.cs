using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Client
    {
        public int clientID { set; get; }
        [Required]
        [MaxLength(15)]
        public string name { set; get; }
        [MaxLength(20)]
        public string contact { set; get; }
        [MaxLength(15)]
        public string phoneNumber { set; get; }
        [Required]
        [MaxLength(100)]
        public string address { set; get; }

        //public virtual Benefit Benefit { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

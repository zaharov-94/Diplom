using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        [Required]
        [MaxLength(15)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(15)]
        public string lastName { get; set; }
        [Required]
        [MaxLength(15)]
        public string login { set; get; }
        [Required]
        [MaxLength(15)]
        public string password { set; get; }
        [Required]
        public DateTime birthDay { get; set; }
        [MaxLength(15)]
        public string phoneNumber { get; set; }
        [Required]
        [MaxLength(15)]
        public string position { get; set; }
        //public int authdataID { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Supply> Supplies { get; set; }

    }
}

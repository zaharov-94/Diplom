using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DataAccess
{
    class Context : DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Employee> employes { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderProduct> orderProducts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Provider> providers { get; set; }
        public DbSet<Supply> supplies { get; set; }
        public DbSet<SupplyProduct> supplyProducts { get; set; }

    }
}

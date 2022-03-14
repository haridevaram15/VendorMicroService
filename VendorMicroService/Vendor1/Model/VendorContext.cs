using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor1.Model
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions<VendorContext> option) : base(option)
        {

        }

        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<VendorStock> VendorStock { get; set; }
    }
}

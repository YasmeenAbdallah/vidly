using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vidly.Models
{
    public class ModelDbContex: DbContext
    {
        public ModelDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customers> customers { get; set; }
        public DbSet<movie> movies { get; set; }
        public DbSet<MemberShipType> MemberShipType { get; set; }
    }
}

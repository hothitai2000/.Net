using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Framework
{
    public partial class dbcontext : DbContext
    {
        public dbcontext()
            : base("name=dbcontext")
        {
        }

        public virtual DbSet<tbl_account> tbl_account { get; set; }
        public virtual DbSet<tbl_products> tbl_products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_products>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}

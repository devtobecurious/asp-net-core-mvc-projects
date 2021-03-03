using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Data
{
    public class SelfieAWookieDbContext : DbContext
    {
        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Selfie>(new EntityConfigurations.SelfieEntityTypeConfiguration());
        }
        #endregion

        #region Properties
        public DbSet<Wookie> Wookies { get; set; }

        public DbSet<Selfie> Selfies { get; set; }
        #endregion
    }
}

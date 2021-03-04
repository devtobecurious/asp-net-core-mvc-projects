using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Data
{
    public class SelfieAWookieDbContext : DbContext
    {
        #region Constructors
        protected SelfieAWookieDbContext()
        {
        }

        public SelfieAWookieDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Selfie>(new EntityConfigurations.SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Wookie>(new EntityConfigurations.WookieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Weapon>(new EntityConfigurations.WeaponEntityTypeConfiguration());
        }
        #endregion

        #region Properties
        public DbSet<Wookie> Wookies { get; set; }

        public DbSet<Selfie> Selfies { get; set; }

        public DbSet<Weapon> Weapons { get; set; }
        #endregion
    }
}

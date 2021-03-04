using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Data.EntityConfigurations
{
    public class WeaponEntityTypeConfiguration : IEntityTypeConfiguration<Weapon>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapon");
            builder.HasKey(item => item.Id);

        }
        #endregion
    }
}

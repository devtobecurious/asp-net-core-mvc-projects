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
    public class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Wookie> builder)
        {
            builder.ToTable("Wookie");
            builder.HasKey(item => item.Id);

            builder.Property(item => item.Surname).IsRequired(true);

            builder.Ignore(item => item.HelpsWeapons);
        }
        #endregion
    }
}

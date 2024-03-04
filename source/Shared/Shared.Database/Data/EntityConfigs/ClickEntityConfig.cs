using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Database.Data.EntityConfigs;

public class ClickEntityConfig : IEntityTypeConfiguration<Click>
{
	public void Configure(EntityTypeBuilder<Click> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedOnAdd();

		builder.Property(x => x.LinkId).IsRequired();
		builder.Property(x => x.ClickDateTime).IsRequired();
		builder.Property(x => x.IpAddress).IsRequired();
		builder.Property(x => x.UserAgent).IsRequired();
	}
}

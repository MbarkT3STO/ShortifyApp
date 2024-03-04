namespace Shared.Database.Data.EntityConfigs;

public class LinkEntityConfig : IEntityTypeConfiguration<Link>
{
	public void Configure(EntityTypeBuilder<Link> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedOnAdd();

		builder.Property(x => x.OriginalUrl).IsRequired();
		builder.Property(x => x.ShortUrl).IsRequired();
		builder.Property(x => x.CreationDateAndTime).IsRequired();
		builder.Property(x => x.ExpirationDateAndTime).IsRequired();
		builder.Property(x => x.IsActive).IsRequired();

		builder.HasMany(x => x.Clicks).WithOne(x => x.Link).HasForeignKey(x => x.LinkId);
	}
}
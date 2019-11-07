namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> town)
        {
            town.HasOne(c => c.Country)
                .WithMany(t => t.Towns)
                .HasForeignKey(c => c.CountryId);

            town.Property(p => p.Name)
                .IsRequired(true);

            town.Property(p => p.CountryId)
               .IsRequired(true);
        }
    }
}

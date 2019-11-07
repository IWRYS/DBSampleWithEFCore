namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> team)
        {
            team.HasOne(x => x.Town)
                  .WithMany(t => t.Teams)
                  .HasForeignKey(x => x.TownId);

            team.HasOne(c => c.PrimaryKitColor)
                .WithMany(x => x.PrimaryKitTeams)
                .HasForeignKey(c => c.PrimaryKitColorId);

            team.HasOne(c => c.SecondaryKitColor)
                .WithMany(x => x.SecondaryKitTeams)
                .HasForeignKey(c => c.SecondaryKitColorId);


            team.Property(p => p.Name)
                .IsRequired(true);

            team.Property(p => p.LogoUrl)
              .IsRequired(true);

            team.Property(p => p.Initials)
              .IsRequired(true);

            team.Property(p => p.PrimaryKitColorId)
              .IsRequired(true);


            team.Property(p => p.SecondaryKitColorId)
              .IsRequired(true);

            team.Property(p => p.TownId)
              .IsRequired(true);

            team.Property(p => p.Budget)
              .IsRequired(true);
        }
    }
}

namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> player)
        {
            player.HasOne(t => t.Team)
                 .WithMany(p => p.Players)
                 .HasForeignKey(t => t.TeamId);

            player.HasOne(p => p.Position)
                .WithMany(pl => pl.Players)
                .HasForeignKey(p => p.PositionId);


            player.Property(p => p.Name)
                .IsRequired(true);

            player.Property(p => p.IsInjured)
                .IsRequired(true);

            player.Property(p => p.PositionId)
              .IsRequired(true);

            player.Property(p => p.TeamId)
              .IsRequired(true);

            player.Property(p => p.SquadNumber)
             .IsRequired(true);
        }
    }
}

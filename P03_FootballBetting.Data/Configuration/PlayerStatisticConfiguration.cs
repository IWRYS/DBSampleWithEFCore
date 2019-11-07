namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public  class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {

        public void Configure(EntityTypeBuilder<PlayerStatistic> playerStatistic)
        {
            playerStatistic.HasKey(ps => new { ps.GameId, ps.PlayerId });

            playerStatistic.HasOne(x => x.Game)
                .WithMany(g => g.PlayerStatistics)
                .HasForeignKey(x => x.GameId);

            playerStatistic.HasOne(p => p.Player)
                .WithMany(ps => ps.PlayerStatistics)
                .HasForeignKey(p => p.PlayerId);

            playerStatistic.Property(p => p.ScoredGoals)
             .IsRequired(true);

            playerStatistic.Property(p => p.MinutesPlayed)
            .IsRequired(true);

            playerStatistic.Property(p => p.Assists)
            .IsRequired(true);
        }
    }
}

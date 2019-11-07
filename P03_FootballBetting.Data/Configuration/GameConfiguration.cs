namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> game)
        {
            game.HasOne(x => x.HomeTeam)
                .WithMany(p => p.HomeGames)
                .HasForeignKey(x => x.HomeTeamId);

            game.HasOne(x => x.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(x => x.AwayTeamId);

            game.Property(g => g.AwayTeamId)
                .IsRequired(true);

            game.Property(g => g.AwayTeamBetRate)
                .IsRequired(true);

            game.Property(g => g.AwayTeamGoals)
                .IsRequired(true);

            game.Property(g => g.HomeTeamId)
                 .IsRequired(true);

            game.Property(g => g.HomeTeamBetRate)
                 .IsRequired(true);
    
            game.Property(g => g.HomeTeamGoals)
                .IsRequired(true);

            game.Property(g => g.Result)
                .IsRequired(true);

            game.Property(g => g.DateTime)
             .IsRequired(true);

            game.Property(g => g.DrawBetRate)
                 .IsRequired(true);
        }
    }
}

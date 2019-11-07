namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> bet)
        {
            bet.HasOne(x => x.Game)
                .WithMany(c => c.Bets)
                .HasForeignKey(x => x.GameId);

            bet.HasOne(u => u.User)
                .WithMany(b => b.Bets)
                .HasForeignKey(u => u.UserId);

            bet.Property(b => b.Amount)
                .IsRequired(true);

            bet.Property(b => b.Prediction)
                .IsRequired(true);

            bet.Property(b => b.DateTime)
                .IsRequired(true);

            bet.Property(b => b.UserId)
               .IsRequired(true);
        }
    }
}

namespace P03_FootballBetting.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.Property(p => p.Name)
                  .IsRequired(true);

            user.Property(p => p.Username)
                  .IsRequired(true);

            user.Property(p => p.Password)
               .IsRequired(true);

            user.Property(p => p.Email)
              .IsRequired(true);

            user.Property(p => p.Balance)
              .IsRequired(true);
        }
    }
}

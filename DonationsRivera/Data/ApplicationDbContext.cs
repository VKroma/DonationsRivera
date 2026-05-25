using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonationsRivera.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Donation> Donations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Donation>(entity =>
        {
            entity.HasKey(d => d.Id);

            entity.HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .IsRequired();

            entity.Property(d => d.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            entity.Property(d => d.Currency)
                .HasMaxLength(3)
                .IsRequired();

            entity.Property(d => d.Status)
                .IsRequired();

            entity.Property(d => d.CreatedAt)
                .IsRequired();

            entity.Property(d => d.StripeSessionId)
                .HasMaxLength(255);
        });
    }
}
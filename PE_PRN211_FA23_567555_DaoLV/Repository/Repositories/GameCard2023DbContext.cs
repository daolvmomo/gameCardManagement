using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;

namespace Repository.Repositories;

public partial class GameCard2023DbContext : DbContext
{
    public GameCard2023DbContext()
    {
    }

    public GameCard2023DbContext(DbContextOptions<GameCard2023DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GameCardInfo> GameCardInfos { get; set; }

    public virtual DbSet<MemberAccount> MemberAccounts { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DefaultConnectionStringDB"];
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameCardInfo>(entity =>
        {
            entity.HasKey(e => e.GameCardId).HasName("PK__GameCard__903C838C9DD54380");

            entity.ToTable("GameCardInfo");

            entity.Property(e => e.GameCardId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GameCardName).HasMaxLength(90);
            entity.Property(e => e.GameDescription).HasMaxLength(250);
            entity.Property(e => e.GamePlatform).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProviderId).HasMaxLength(30);

            entity.HasOne(d => d.Provider).WithMany(p => p.GameCardInfos)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__GameCardI__Provi__4F7CD00D");
        });

        modelBuilder.Entity<MemberAccount>(entity =>
        {
            entity.HasKey(e => e.MemberAccountId).HasName("PK__MemberAc__0FB640588F120C01");

            entity.ToTable("MemberAccount");

            entity.HasIndex(e => e.MemberEmail, "UQ__MemberAc__3F37B77ADF338BE0").IsUnique();

            entity.Property(e => e.MemberAccountId)
                .ValueGeneratedNever()
                .HasColumnName("MemberAccountID");
            entity.Property(e => e.MemberAccountPassword).HasMaxLength(60);
            entity.Property(e => e.MemberEmail).HasMaxLength(100);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PK__Provider__B54C687D9BD430F4");

            entity.ToTable("Provider");

            entity.Property(e => e.ProviderId).HasMaxLength(30);
            entity.Property(e => e.ProviderDescription).HasMaxLength(250);
            entity.Property(e => e.ProviderName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

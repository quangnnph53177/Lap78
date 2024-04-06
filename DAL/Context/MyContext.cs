using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Quan> Quans { get; set; }

    public virtual DbSet<Thanhpho> Thanhphos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-HEG4PA5 ;Initial Catalog=QLYTP;;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quan>(entity =>
        {
            entity.HasKey(e => e.Maquan).HasName("PK__QUAN__1B4FDCE2A8F4022D");
        });

        modelBuilder.Entity<Thanhpho>(entity =>
        {
            entity.HasKey(e => e.Matp).HasName("PK__THANHPHO__60237213731202A4");

            entity.Property(e => e.Stt).ValueGeneratedOnAdd();

            entity.HasOne(d => d.MaquanNavigation).WithMany(p => p.Thanhphos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__THANHPHO__MAQUAN__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

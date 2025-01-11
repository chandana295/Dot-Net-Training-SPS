using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrainerLibrary.Models;

public partial class SPSTrainerDBsnraoContext : DbContext
{
    public SPSTrainerDBsnraoContext()
    {
    }

    public SPSTrainerDBsnraoContext(DbContextOptions<SPSTrainerDBsnraoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Trainer> Trainers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=sqlsvrsnrao.database.windows.net; database=SPSTrainerDB-snrao; user id=snrao; password=Welcome@1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.TrainerId).HasName("PK__Trainer__366A1A7C68EEF45B");

            entity.ToTable("Trainer");

            entity.Property(e => e.TrainerId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrainerEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TrainerName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TrainerPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrainerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

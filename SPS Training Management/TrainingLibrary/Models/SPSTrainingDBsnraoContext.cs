using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrainingLibrary.Models;

public partial class SPSTrainingDBsnraoContext : DbContext
{
    public SPSTrainingDBsnraoContext()
    {
    }

    public SPSTrainingDBsnraoContext(DbContextOptions<SPSTrainingDBsnraoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Technology> Technologies { get; set; }

    public virtual DbSet<Trainee> Trainees { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<Training> Training { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=sqlsvrsnrao.database.windows.net; database=SPSTrainingDB-snrao; user id=snrao; password=Welcome@1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBB991B1CDDD0");

            entity.ToTable("Employee");

            entity.Property(e => e.EmpId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Technology>(entity =>
        {
            entity.HasKey(e => e.TechId).HasName("PK__Technolo__8AFFB87FEDC3C8C5");

            entity.ToTable("Technology");

            entity.Property(e => e.TechId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Trainee>(entity =>
        {
            entity.HasKey(e => new { e.TrainingId, e.TraineeId }).HasName("PK__Trainee__5B6D8C9EC21FC088");

            entity.ToTable("Trainee");

            entity.Property(e => e.TrainingId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TraineeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.TraineeNavigation).WithMany(p => p.Trainees)
                .HasForeignKey(d => d.TraineeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Trainee__Trainee__656C112C");

            entity.HasOne(d => d.Training).WithMany(p => p.Trainees)
                .HasForeignKey(d => d.TrainingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Trainee__Trainin__6477ECF3");
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.TrainerId).HasName("PK__Trainer__366A1A7C4B3A6432");

            entity.ToTable("Trainer");

            entity.Property(e => e.TrainerId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.TrainingId).HasName("PK__Training__E8D71D82B86F1E8F");

            entity.Property(e => e.TrainingId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TechId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrainerId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Tech).WithMany(p => p.Training)
                .HasForeignKey(d => d.TechId)
                .HasConstraintName("FK__Training__TechId__66603565");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Training)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__Training__Traine__6754599E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

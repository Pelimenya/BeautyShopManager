using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BeautyShopManager.Models;

public partial class ContextDataBase : DbContext
{
    public ContextDataBase()
    {
    }

    public ContextDataBase(DbContextOptions<ContextDataBase> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Loss> Losses { get; set; }

    public virtual DbSet<Salesplan> Salesplans { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Workhour> Workhours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("host=localhost; port=5432; database=BeautyShopManagerDB; username=Pelimenya; password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("employees_pkey");

            entity.ToTable("employees");

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Hiredate).HasColumnName("hiredate");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
        });

        modelBuilder.Entity<Loss>(entity =>
        {
            entity.HasKey(e => e.Lossid).HasName("losses_pkey");

            entity.ToTable("losses");

            entity.Property(e => e.Lossid).HasColumnName("lossid");
            entity.Property(e => e.Disposal)
                .HasPrecision(10, 2)
                .HasColumnName("disposal");
            entity.Property(e => e.Inventoryloss)
                .HasPrecision(10, 2)
                .HasColumnName("inventoryloss");
            entity.Property(e => e.Lossdate).HasColumnName("lossdate");
            entity.Property(e => e.Shortage)
                .HasPrecision(10, 2)
                .HasColumnName("shortage");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Losses)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("losses_userid_fkey");
        });

        modelBuilder.Entity<Salesplan>(entity =>
        {
            entity.HasKey(e => e.Planid).HasName("salesplan_pkey");

            entity.ToTable("salesplan");

            entity.Property(e => e.Planid).HasColumnName("planid");
            entity.Property(e => e.Achievedamount)
                .HasPrecision(10, 2)
                .HasColumnName("achievedamount");
            entity.Property(e => e.Planmonth).HasColumnName("planmonth");
            entity.Property(e => e.Targetamount)
                .HasPrecision(10, 2)
                .HasColumnName("targetamount");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Salesplans)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("salesplan_userid_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "users_username_key").IsUnique();

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Passwordhash)
                .HasMaxLength(255)
                .HasColumnName("passwordhash");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Employee).WithMany(p => p.Users)
                .HasForeignKey(d => d.Employeeid)
                .HasConstraintName("users_employeeid_fkey");
        });

        modelBuilder.Entity<Workhour>(entity =>
        {
            entity.HasKey(e => e.Workhourid).HasName("workhours_pkey");

            entity.ToTable("workhours");

            entity.Property(e => e.Workhourid).HasColumnName("workhourid");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Hoursworked)
                .HasPrecision(5, 2)
                .HasColumnName("hoursworked");
            entity.Property(e => e.Workdate).HasColumnName("workdate");

            entity.HasOne(d => d.Employee).WithMany(p => p.Workhours)
                .HasForeignKey(d => d.Employeeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workhours_employeeid_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

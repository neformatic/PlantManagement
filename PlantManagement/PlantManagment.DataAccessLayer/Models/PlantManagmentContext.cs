using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PlantManagment.DataAccessLayer.Models
{
    public partial class PlantManagmentContext : DbContext
    {
        public PlantManagmentContext()
        {
        }

        public PlantManagmentContext(DbContextOptions<PlantManagmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountStatus> AccountStatuses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QSHVTJH;Database=PlantManagment;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountLogin)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accounts__Accoun__1FCDBCEB");
            });

            modelBuilder.Entity<AccountStatus>(entity =>
            {
                entity.ToTable("AccountStatus");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName).HasMaxLength(100);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__Accou__22AA2996");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__Depar__239E4DCF");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__Posit__24927208");
            });

            modelBuilder.Entity<EmployeeProject>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeP__Emplo__20C1E124");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeP__Proje__21B6055D");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionName).HasMaxLength(100);

                entity.HasOne(d => d.Departmnet)
                    .WithMany(p => p.Positions)
                    .HasForeignKey(d => d.DepartmnetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Positions__Depar__25869641");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectName).HasMaxLength(100);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.TaskName).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tasks__ProjectId__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

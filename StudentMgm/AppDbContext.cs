using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentMgm.Models;
using System.IO;

namespace StudentMgm;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
    
    // Parameterless constructor for direct instantiation
    public AppDbContext()
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=StudentMgm;User Id=sa;Password=YourStrong(!)Password;TrustServerCertificate=True;");
        }
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Student entity
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentID);
            entity.Property(e => e.StudentName)
                .IsRequired()
                .HasMaxLength(100);
        });

        // Configure Course entity
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseID);
            entity.Property(e => e.CourseName)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Grade)
                .HasMaxLength(10);
        });

        // Configure Enrollment entity (junction table)
        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId);
            
            // Configure relationships
            entity.HasOne<Student>()
                .WithMany()
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne<Course>()
                .WithMany()
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Create composite index for StudentId and CourseId
            entity.HasIndex(e => new { e.StudentId, e.CourseId })
                .IsUnique();
        });
    }
}
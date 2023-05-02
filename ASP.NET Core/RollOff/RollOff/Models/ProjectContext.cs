using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RollOff.Models
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Roll> Rolls { get; set; }
        public virtual DbSet<SupplyDatum> SupplyData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LIN24006509\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(255)
                    .HasColumnName("Confirm Password");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .HasColumnName("Email Id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Password).HasMaxLength(255);
            });

            

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Login");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .HasColumnName("Email Id");

                entity.Property(e => e.Password).HasMaxLength(255);
            });

            

            modelBuilder.Entity<Roll>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__Roll__682E16CF21448825");

                entity.ToTable("Roll");

                entity.Property(e => e.EmployeeNo).HasColumnName("Employee no");

                entity.Property(e => e.Communication).HasMaxLength(255);

                entity.Property(e => e.GlobalGroupId).HasColumnName("Global Group ID");

                entity.Property(e => e.LocalGrade)
                    .HasMaxLength(255)
                    .HasColumnName("Local Grade");

                entity.Property(e => e.LongLeave)
                    .HasMaxLength(255)
                    .HasColumnName("Long Leave");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PerformanceIssue)
                    .HasMaxLength(255)
                    .HasColumnName("Performance Issue");

                entity.Property(e => e.Practice).HasMaxLength(255);

                entity.Property(e => e.PrimarySkill)
                    .HasMaxLength(255)
                    .HasColumnName("Primary Skill");

                entity.Property(e => e.ProjectCode).HasColumnName("Project Code");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(255)
                    .HasColumnName("Project Name");

                entity.Property(e => e.ReasonForRollOff)
                    .HasMaxLength(255)
                    .HasColumnName("Reason For Roll Off");

                entity.Property(e => e.RelevantExperienceYrs).HasColumnName("Relevant Experience(Yrs)");

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Resigned).HasMaxLength(255);

                entity.Property(e => e.RoleCompetencies)
                    .HasMaxLength(255)
                    .HasColumnName("Role/Competencies");

                entity.Property(e => e.RollOffEndDate)
                    .HasColumnType("date")
                    .HasColumnName("Roll-off End Date");

                entity.Property(e => e.TechnicalSkills)
                    .HasMaxLength(255)
                    .HasColumnName("Technical/Skills");

                entity.Property(e => e.ThisReleaseNeedsBackfillIsBackfilled)
                    .HasMaxLength(255)
                    .HasColumnName("This release needs backfill/is backfilled");

                entity.Property(e => e.UnderProbation)
                    .HasMaxLength(255)
                    .HasColumnName("Under Probation");

                entity.HasOne(d => d.GlobalGroup)
                    .WithMany(p => p.Rolls)
                    .HasForeignKey(d => d.GlobalGroupId)
                    .HasConstraintName("FK__Roll__Global Gro__3B75D760");
            });

            modelBuilder.Entity<SupplyDatum>(entity =>
            {
                entity.HasKey(e => e.GlobalGroupId)
                    .HasName("PK__SupplyDa__A8B3AC1A8F0A1217");

                entity.Property(e => e.GlobalGroupId).HasColumnName("Global Group ID");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmployeeNo).HasColumnName("Employee no");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("date")
                    .HasColumnName("Joining Date");

                entity.Property(e => e.LocalGrade)
                    .HasMaxLength(255)
                    .HasColumnName("Local Grade");

                entity.Property(e => e.MainClient)
                    .HasMaxLength(255)
                    .HasColumnName("Main Client");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NewGlobalPractice)
                    .HasMaxLength(255)
                    .HasColumnName("New Global Practice");

                entity.Property(e => e.OfficeCity)
                    .HasMaxLength(255)
                    .HasColumnName("Office City");

                entity.Property(e => e.PeopleManagerPerformanceReviewer)
                    .HasMaxLength(255)
                    .HasColumnName("People Manager (Performance Reviewer)");

                entity.Property(e => e.Practice).HasMaxLength(255);

                entity.Property(e => e.ProjectCode).HasColumnName("Project Code");

                entity.Property(e => e.ProjectEndDate)
                    .HasColumnType("date")
                    .HasColumnName("Project End Date");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(255)
                    .HasColumnName("Project Name");

                entity.Property(e => e.ProjectStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Project Start Date");

                entity.Property(e => e.PspName)
                    .HasMaxLength(255)
                    .HasColumnName("PSP Name");
            });

            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

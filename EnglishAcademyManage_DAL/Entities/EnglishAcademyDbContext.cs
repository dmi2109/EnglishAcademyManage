using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnglishAcademyManage_DAL.Entities
{
    public partial class EnglishAcademyDbContext : DbContext
    {
        public EnglishAcademyDbContext()
            : base("name=EnglishAcademyDbContext")
        {
        }

        public virtual DbSet<AcademicResult> AcademicResults { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicResult>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AcademicResult>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.account_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.class_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.ScheduleDetails)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.AcademicResults)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.registration_id)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduleDetail>()
                .Property(e => e.schedule_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ScheduleDetail>()
                .Property(e => e.class_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.AcademicResults)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }
    }
}

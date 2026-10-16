using Microsoft.EntityFrameworkCore;
using task01.Model;
using static task01.Model.School;

namespace task01.Data
{
    public class ApplicationDBContext : DbContext
    {
        // 1. كونستركتور فارغ مطلوب لأدوات الـ EF Core وقت الـ Migrations
        public ApplicationDBContext()
        {
        }

        // 2. الكونستركتور الأساسي لحقن التبعيات (Dependency Injection)
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "أحمد محمد محمود",
                    Age = 16,
                    Phone = "01012345678"
                },
                new Student
                {
                    Id = 2,
                    Name = "سارة يوسف حسن",
                    Age = 15,
                    Phone = "01123456789"
                },
                new Student
                {
                    Id = 3,
                    Name = "عمر خالد إبراهيم",
                    Age = 17,
                    Phone = "01234567890"
                });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    Name = "أستاذ محمود إبراهيم",
                    Salary = 8500,
                    Email = "mahmoud.ibrahim@school.com"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "أستاذة فاطمة علي",
                    Salary = 9200,
                    Email = "fatma.ali@school.com"
                },
                new Teacher
                {
                    Id = 3,
                    Name = "أستاذ أحمد حسن",
                    Salary = 7800,
                    Email = "ahmed.hassan@school.com"
                });

            modelBuilder.Entity<School>().HasData(
                new School
                {
                    Id = 1,
                    Name = "مدرسة الشهيد العضو الثانوية",
                    Address = "الشهداء، المنوفية",
                    Type = SchoolType.Public
                },
                new School
                {
                    Id = 2,
                    Name = "مدرسة النيل للغات",
                    Address = "شبين الكوم، المنوفية",
                    Type = SchoolType.Experimental
                },
                new School
                {
                    Id = 3,
                    Name = "مدرسة المستقبل الدولية",
                    Address = "تلا، المنوفية",
                    Type = SchoolType.International
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    Name = "الرياضيات",
                    MaxDegree = 100,
                    MinDegree = 50
                },
                new Subject
                {
                    Id = 2,
                    Name = "اللغة العربية",
                    MaxDegree = 80,
                    MinDegree = 40
                },
                new Subject
                {
                    Id = 3,
                    Name = "العلوم",
                    MaxDegree = 50,
                    MinDegree = 25
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
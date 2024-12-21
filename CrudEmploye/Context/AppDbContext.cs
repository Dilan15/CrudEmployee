using CrudEmploye.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudEmploye.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Empleados { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>(tb =>
            {
                tb.HasKey(col => col.IdProfile);

                tb.Property(col => col.IdProfile)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Name)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

                tb.ToTable("Profile");

                tb.HasData(
                        new Profile { IdProfile = 1, Name = "Programador JR"},
                        new Profile { IdProfile = 2, Name = "Programador Dev" },
                        new Profile { IdProfile = 3, Name = "Programador Senior" },
                        new Profile { IdProfile = 4, Name = "Administrador SYS" }
                );
            });

            modelBuilder.Entity<Employee>(tb =>
            {
                tb.HasKey(col => col.IdEmployee);

                tb.Property(col => col.IdEmployee)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.FullName)
                .HasMaxLength(100)
                .IsRequired();

                tb.Property(col => col.Salary)
                .HasColumnType("int")
                .IsRequired();   

                // Table Relationship
                tb.HasOne(col => col.ReferenceProfile)
                .WithMany(p => p.ReferenceEmployee)
                .HasForeignKey(p => p.IdProfile);

                tb.ToTable("Employee");
            }); 
        }
    }
}

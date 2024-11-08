using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityDatabase.Core.Entities;
using UniversityDatabase.Persistance.Configurations;

namespace UniversityDatabase.Persistance.Data
{
    public class UniversityDatabaseContext : DbContext
    {
        public UniversityDatabaseContext(DbContextOptions<UniversityDatabaseContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Student> Student { get; set; } = default!;

        //Not needed for Convention 2, only Con1
        //public DbSet<Enrollment> Enrollments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfigurations());

            //modelBuilder.Entity<Enrollment>().HasKey(e => new { e.CourseId, e.StudentId });
         
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UniversityDatabase.Core.Entities;

namespace UniversityDatabase.Persistance.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> builder)
        {
            builder.OwnsOne(s => s.Name)
             .Property(n => n.FirstName)
             .HasColumnName("FirstName");
            builder.OwnsOne(s => s.Name)
                .Property(n => n.LastName)
                .HasColumnName("LastName");


            builder.HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<Enrollment>(
                e => e.HasOne(e => e.Course).WithMany(c => c.Enrollments),
                e => e.HasOne(e => e.Student).WithMany(s => s.Enrollments),
                e => e.HasKey(e => new { e.CourseId, e.StudentId })
                );
        }
    }
}

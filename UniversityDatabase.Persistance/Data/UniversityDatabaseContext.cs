using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityDatabase.Core.Entities;

namespace UniversityDatabase.Persistance.Data
{
    public class UniversityDatabaseContext : DbContext
    {
        public UniversityDatabaseContext(DbContextOptions<UniversityDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
    }
}

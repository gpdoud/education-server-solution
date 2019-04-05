using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace education_server.Models {
    public class EdDbContext : DbContext {

        public EdDbContext(DbContextOptions<EdDbContext> options) : base(options) {}

        public DbSet<Student> Students { get; set; }

    }
}

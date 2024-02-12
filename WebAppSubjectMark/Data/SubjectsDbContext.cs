using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppSubjectMark.Models;

namespace WebAppSubjectMark.Data
{
    public class SubjectsDbContext : DbContext
    {
        public SubjectsDbContext (DbContextOptions<SubjectsDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppSubjectMark.Models.Subjects> Subjects { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excercise3ASP.Models
{
    public class StudentFormDBContext : DbContext
    {
        public StudentFormDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentRegistrationForm> StudentRegistrationForm { get; set; }
    }
}

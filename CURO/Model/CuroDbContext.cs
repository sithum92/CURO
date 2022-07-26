using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CURO.Controller;

namespace CURO.Model
{
   public class CuroDbContext:DbContext
    {
        public DbSet<Student> Student { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataTables
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("AppDatabase")

        {
        }
        public DbSet<Student> stud { get; set; }
        public DbSet<ContactDetails> ctDetails { get; set; }
    }
}

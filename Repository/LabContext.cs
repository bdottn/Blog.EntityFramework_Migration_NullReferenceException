using Model;
using System.Data.Entity;

namespace Repository
{
    public class LabContext : DbContext
    {
        public LabContext() : base(@"LabContext")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
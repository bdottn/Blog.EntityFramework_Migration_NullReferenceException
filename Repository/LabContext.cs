using Model;
using System.Data.Entity;

namespace Repository
{
    public class LabContext : DbContext
    {
        public LabContext() : base(@"Server=.;Database=Lab;Integrated Security=True;")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
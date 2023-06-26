using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Models
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options)
        {
                
        }


        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dboptions)
        {
            dboptions.UseSqlServer("Data Source=.; Initial Catalog = studentDB; User Id=alakey; password=12345; TrustServerCertificate= True"); 
        }

    }
}

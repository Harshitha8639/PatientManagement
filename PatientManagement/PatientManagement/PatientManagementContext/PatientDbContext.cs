using Microsoft.EntityFrameworkCore;
using PatientManagement.Models;

namespace PatientManagement.PatientManagementContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PatientModel> Patients { get; set; }
    }
}
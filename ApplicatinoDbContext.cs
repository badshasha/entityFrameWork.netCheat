using lastTesting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace lastTesting.data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) // connection to sql server 
        {

        }

        public DbSet<Publisher> publishers { get; set; } // table and table name 

    }
}

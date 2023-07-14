using coffeeshop.Models;
using Microsoft.EntityFrameworkCore;


namespace coffeeshop.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // account =  from models->account.cs, accountstbl =  name of table
        public DbSet<coffeeList> coffeetbl { get; set; }

    }
}

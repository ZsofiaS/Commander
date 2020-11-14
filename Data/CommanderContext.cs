using Commander.Models;
using Microsoft.EntityFrameworkCore; //namespace

namespace Commander.Data
{
    // inherits from DbContext (from EntityFramework)
    public class CommanderContext : DbContext
    {
        // constructor
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        // create representation of our model in the db
        public DbSet<Command> Commands { get; set; }
    } 
}
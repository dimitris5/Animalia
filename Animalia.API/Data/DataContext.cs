using Animalia.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Animalia.API.Data
{
    public class DataContext : DbContext //query and save instances about entities
    {                                    //(f.e. send a query to db from table)
        public DataContext(DbContextOptions<DataContext> options ) : base (options) {} //chain to base constractor

        //to let entity framework know about our entities, we give names to our properties
       
       public DbSet<Value> Values { get; set; }
    }
}
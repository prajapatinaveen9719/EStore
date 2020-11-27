using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStore.Entities;


namespace EStore.Database
{
    public class EStoreContext:DbContext
    {
        public EStoreContext():base("name=EStoreContext")
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}

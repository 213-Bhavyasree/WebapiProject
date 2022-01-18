using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebapiProject.Model;

namespace WebapiProject.Data
{
    public class WebapiProjectContext : DbContext
    {
        public WebapiProjectContext (DbContextOptions<WebapiProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebapiProject.Model.Customer> Customer { get; set; }
    }
}

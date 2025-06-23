using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SerwisModels;
using System.Text;
using System.Threading.Tasks;

namespace SerwisDataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<RequestModel> Request { get; set; }

    }
}

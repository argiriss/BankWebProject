using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankProject.Models
{
    public class AppDbContext:DbContext
    {
        //properties
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }

        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}

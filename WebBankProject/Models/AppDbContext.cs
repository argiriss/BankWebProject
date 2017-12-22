using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankProject.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Account> Account { get; set; }
        //missing users

        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}

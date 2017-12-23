using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankProject.Models.Services
{
    public class EFUserRepository : IUserRepository
    {
        private AppDbContext db;

        //constructor
        public EFUserRepository(AppDbContext db)
        {
            this.db = db;
        }

        //With this we are getting list with users.From interface 
        //Only for read
        public IQueryable<User> Users => db.Users;
    }
}

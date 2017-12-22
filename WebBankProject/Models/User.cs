using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankProject.Models
{
    public class User
    {
        public int Id { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public User(string username , string password)
        {
            Username = username;
            Password = password;
        }
    }
}

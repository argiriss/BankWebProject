using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankProject
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public  DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}

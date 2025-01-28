using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.P02_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string CreditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; } = new List<Sale>(); // we can't add sales attribute because sales to customer is one to many so we list of sales here as one custmer can maky many sales 


    }
}

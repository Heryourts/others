using System.ComponentModel.DataAnnotations;

namespace MyOrm
{   
    public class BankAccount : IdentifierBase
    {        
        public int AccountNumber { get; set; }
        public Owner Owner { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
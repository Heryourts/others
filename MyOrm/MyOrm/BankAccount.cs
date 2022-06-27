using System.ComponentModel.DataAnnotations;

namespace MyOrm
{   
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public string Owner { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
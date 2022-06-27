using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOrm
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Note { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        
        
        
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}

namespace Events
{
    public delegate void BalanceNotifier(decimal balance, 
                                         TransactionType transactionType);

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string Owner { get; set; }
        public List<Transaction> Transactions { get; private set; }
        public event BalanceNotifier OnBalanceNotifierEvent;


        public BankAccount(string name, decimal balance)
        {
            if (balance < 10)
                throw new BalanceNotAllowedException(balance);


            AccountNumber = 100004;
            Owner = name;
            Transactions = new List<Transaction>();
            Transactions.Add(new Transaction { Note = "Initial balance", Amount = balance, Type = TransactionType.Deposit });

        }

        public decimal Balance
        {
            get {                 
                return Transactions.Select(p => p.Amount).Sum();
            }
        }

        public void MakeDeposit(decimal amount, string note)
        {
            if (amount <= 0)
                throw new DepositAmountNotAllowedException(amount);


            Transactions.Add(new Transaction { Note = note, Amount = amount, Type = TransactionType.Deposit });

            //if (OnBalanceNotifierEvent != null)
            //    OnBalanceNotifierEvent(Balance, TransactionType.Deposit);

            OnBalanceNotifierEvent?.Invoke(Balance, TransactionType.Deposit);

        }

        public void MakeWithdrawal(decimal amount, string note)
        {
            Transactions.Add(new Transaction { Note = note, Amount = amount * -1, Type = TransactionType.Withdrawal });

            //if (OnBalanceNotifierEvent != null)
            //    OnBalanceNotifierEvent(Balance, TransactionType.Withdrawal);

            OnBalanceNotifierEvent?.Invoke(Balance, TransactionType.Withdrawal);


        }
    }
}
// See https://aka.ms/new-console-template for more information

using MyOrm;

using (var context = new MyOrmContext())
{
    var bankAccount = new BankAccount { AccountNumber = 100, Owner = "Jose Perez" };
    context.BankAccount.Add(bankAccount);    

    for (int i = 0; i < 10; i++)
    {
        context.Transaction.Add(new Transaction { Amount = 250, 
                                                  BankAccount = bankAccount, 
                                                  Date = DateTime.Now, 
                                                  Note = "Deposito", 
                                                  Type = TransactionType.Deposit });
    }

    context.SaveChanges();
}



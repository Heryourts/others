//https://aka.ms/new-console-template for more information
using Events;

try
{

    var bankAccount = new BankAccount("Juan Perez", 1000);

    bankAccount.OnBalanceNotifierEvent += ConsoleNotifier;
    bankAccount.OnBalanceNotifierEvent += EmailNotifier;
    bankAccount.OnBalanceNotifierEvent += WhatsappNotifier;

    PrintBankAccount(bankAccount);

    bankAccount.MakeDeposit(132, "ATM Deposit ");
    bankAccount.MakeWithdrawal(200, "Withdrawal made in person");
    bankAccount.MakeWithdrawal(100, "Netflix ");
    bankAccount.MakeDeposit(50, "Interests");
    bankAccount.MakeDeposit(80, "From Jose Lopez");
    bankAccount.MakeWithdrawal(2130, "Made in person");

    PrintTransactions(bankAccount);
    PrintBankAccount(bankAccount);
}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
catch (BalanceNotAllowedException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DepositAmountNotAllowedException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program finished");
}

void PrintBankAccount(BankAccount bankAccount)
{
    Console.WriteLine($"La cuenta {bankAccount.AccountNumber} de {bankAccount.Owner} tiene un balance de {bankAccount.Balance}");
}

void PrintTransactions(BankAccount bankAccount)
{
    foreach (var transaction in bankAccount.Transactions)
    {
        Console.WriteLine($"{transaction.Date.ToString("MM/dd/yyyy H:mm:ss")} { transaction.Note.PadRight(50, ' ')}  {transaction.Type.ToString().PadRight(10)}    $/ {transaction.Amount} ");
    }
}

void EmailNotifier(decimal balance, TransactionType transaction)
{
    Console.WriteLine("Sending to email .........");
}

void WhatsappNotifier(decimal balance, TransactionType transaction)
{
    Console.WriteLine("Sending to whatsapp .........");
}

void ConsoleNotifier(decimal balance, TransactionType transaction)
{
    Console.WriteLine($"The balance after transaction {transaction} is :{balance}");
}

//https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings




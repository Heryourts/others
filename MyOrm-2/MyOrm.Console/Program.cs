// See https://aka.ms/new-console-template for more information

using MyOrm;

Console.WriteLine("hi");
using (var context = new MyOrmContext())
{
    //Organization organizacion = new Organization
    //{
    //    Address = "Av . Paulista 452",
    //    Email = "contact@smart.com",
    //    LegalName = "SAMRT SRL",
    //    LegalIdentifier = "1234-456-789"
    //};

    //context.Organization.Add(organizacion);


    

    for (int i = 0; i < 100; i++)
    {
        NaturalPerson naturalPerson = new NaturalPerson
        {
            FirstName = "Michael "+i,
            LastName = "Lopez "+i,
            Email = $"michael.lopez{i}@gmail.com",
            Address = "Home Street #"+i,
            BirthDate = new DateTime(2000, 10, 01),
            Gender = (i%2 == 0)?Gender.Male:Gender.Female
        };

        context.NaturalPerson.Add(naturalPerson);
    }

    context.SaveChanges();  
    



    //var bankAccount = new BankAccount { AccountNumber = 100, Owner = organizacion };
    //context.BankAccount.Add(bankAccount);

    //for (int i = 0; i < 10; i++)
    //{
    //    context.Transaction.Add(new Transaction
    //    {
    //        Amount = 250,
    //        BankAccount = bankAccount,
    //        Date = DateTime.Now,
    //        Note = "Deposito",
    //        Type = TransactionType.Deposit
    //    });
    //}

    //context.SaveChanges();






}



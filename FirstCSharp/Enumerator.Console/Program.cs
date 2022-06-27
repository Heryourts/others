// See https://aka.ms/new-console-template for more information
using Enumerator;

Console.WriteLine("Hello, World!");

var customer = new Customer("Fabiola Mendez", email: "fabi@gmail.com", Genre.Female);

PrintCustomer(customer);

void PrintCustomer(Customer customer)
{
    Console.WriteLine($"{customer.Name} with email {customer.Email} as {customer.Genre}");
}
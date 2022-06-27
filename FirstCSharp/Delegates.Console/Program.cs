// See https://aka.ms/new-console-template for more information


using Delegates;
using System.Diagnostics;

var customer = new Customer("Fabiola Mendez", email: "fabi@gmail.com", Genre.Female);
customer.Print(WriteInConsole);
customer.Print(WriteInFile);


void WriteInConsole(string message)
{
    Console.WriteLine(message);
}

void WriteInFile(string message)
{
    var fileName = "fichero.txt";
    File.AppendAllText(fileName, message);
    Process.Start("notepad.exe", fileName);
}


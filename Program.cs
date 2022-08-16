using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__Sorting_Bank_Information_with_orderby_criteria
{
    class Program
    {
        class Account
        {
            public string FirstName { get; private set; }
            public string Lastname { get; private set; }
            public double Balance { get; private set; }        
            public string AccountNumber { get; private set; }

            public Account(string fn, string ln, double b, string accnum)
            {
                FirstName = fn;
                Lastname = ln;
                Balance = b;
                AccountNumber = accnum;
            }
        }

        static void Main(string[] args)
        {
            Account[] accounts =  
            { 
            new Account("Forhad", "Hossain", 100.23, "166.102.55.666"),
            new Account("Abul ", "Khan", 1000.23, "366.102.55.666"),
            new Account("Kasem", "Islam", 1400.23, "466.102.55.666"),
            new Account("Anis", "Ali", 10450.23, "566.102.55.666"),
            new Account("Rahman", "Hossain", 14500.23, "666.102.55.666"),
            new Account("Karim", "Hossain", 10450.23, "766.102.55.666"),
            new Account("Shajanan", "Khan", 10780.23, "866.102.55.666"),
            new Account("Jinu", "Ali", 1070.23, "966.102.55.666"),
            new Account("Anarul", "Hossain", 7100.23, "106.102.55.666")         
            };

            // Create a query that obtains the acconts in sorted oreder
            // Sorting first by last name, then within same last names sorting by 
            // by first name , and finally by account balance

            var accInfo = from acc in accounts
                          orderby acc.FirstName, acc.Lastname, acc.AccountNumber, acc.Balance
                          select acc;

            Console.WriteLine("Account is sorted order : ");
            string str = "";

            // Display result

            foreach(Account acc in accInfo)
            {
                if(str != acc.FirstName){
                    Console.WriteLine();
                    str = acc.FirstName;
                }

                Console.WriteLine($"{acc.FirstName}, {acc.Lastname}, Acc#:{acc.AccountNumber}, {acc.Balance}");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

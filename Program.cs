using System;

namespace IsleExpedionsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount. MyAccountNumber = 123456;
            myAccount.AccountName = "My collection";
            myAccount.Collection = 200;
            myAccount.Deposit(1001);
            Console.WriteLine("AN: {MyAccount.AccountNumber}");
        }
    }
}

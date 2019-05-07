using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Receiver class
    /// </summary>
    public class Account
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}

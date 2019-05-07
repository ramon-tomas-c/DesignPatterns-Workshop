using System;

namespace CommandPattern
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }

    /// <summary>
    /// Command implementations
    /// </summary>
    public class Withdraw 
    {       
        public Withdraw(Account account, decimal amount)
        {
           
        }
    }

    public class Deposit
    {       
        public Deposit(Account account, decimal amount)
        {
           
        }
    }
}

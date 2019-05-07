using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Invoker class
    /// </summary>
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get { return _transactions.Any(x => !x.IsCompleted); }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            // Apply transactions with commands.
            foreach (ITransaction transaction in _transactions.Where(x => !x.IsCompleted))
            {
                Console.WriteLine($"Executing command {transaction.GetType().Name}");
                transaction.Execute();
            }
        }
    }
}

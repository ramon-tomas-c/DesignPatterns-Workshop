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
    public class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Withdraw(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                IsCompleted = true;
            }
        }
    }

    public class Deposit : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Deposit(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            _account.Balance += _amount;

            IsCompleted = true;
        }
    }
}

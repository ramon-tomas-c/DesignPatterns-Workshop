using System;

namespace DecoratorPattern
{
    public abstract class Notifier
    {
        public abstract void Send(string msg);
    }

    /// <summary>
    /// Concrete component
    /// </summary>
    public class DefaultNotifier
    {
        
    }
}

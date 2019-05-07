using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Decorator Abstract class
    /// </summary>
    public abstract class Decorator : Notifier
    {
        protected Notifier _notifier;

        public Decorator(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override void Send(string msg)
        {
            _notifier.Send(msg);
        }
    }

    /// <summary>
    /// Specific Decorators
    /// </summary>
    public class FaceBookNotifierDecorator : Decorator
    {
        public FaceBookNotifierDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine($"Sending Message to Facebook: {msg}");
        }
    }

    public class SMSNotifierDecorator : Decorator
    {
        public SMSNotifierDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine($"Sending Message to SMS: {msg}");
        }
    }
}

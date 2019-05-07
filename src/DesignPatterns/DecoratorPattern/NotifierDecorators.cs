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

        }

        public override void Send(string msg)
        {

        }
    }

    /// <summary>
    /// Specific Decorators
    /// </summary>
    public class FaceBookNotifierDecorator
    {
        public FaceBookNotifierDecorator(Notifier notifier) 
        {
        }

       
    }

    public class SMSNotifierDecorator 
    {
        public SMSNotifierDecorator(Notifier notifier) 
        {
        }

       
    }
}

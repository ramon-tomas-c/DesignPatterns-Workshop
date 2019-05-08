using System;

namespace StatePattern
{
    public abstract class State
    {
        protected DocumentContext _context;

        public void SetContext(DocumentContext context)
        {
            _context = context;
        }

        public abstract void Publish(bool isAdmin);

        public abstract void Validate();
    }

    /// <summary>
    /// Initial state
    /// </summary>
    public class Draft : State
    {
        public override void Publish(bool isAdmin)
        {
            // If the doc is published by an admin there's no need to validate
            if (isAdmin)
            {
                Console.WriteLine("Document published!");
                _context.TransitionTo(new Published());
            }
            else
            {
                Console.WriteLine("Document pending to validate");
                _context.TransitionTo(new PendingValidate());
            }
        }

        public override void Validate()
        {
            Console.WriteLine("You first need to publish a document before validating");
        }
    }

    /// <summary>
    /// Pending validate state
    /// </summary>
    public class PendingValidate : State
    {
        public override void Publish(bool isAdmin)
        {
            Console.WriteLine("The document cannot be published before validating");
        }

        public override void Validate()
        {
            // logic that validates the doc
            bool isValidationSucceded = true;

            if (isValidationSucceded)
            {
                Console.WriteLine("Document published");
                _context.TransitionTo(new Published());
            }
            else
            {
                Console.WriteLine("Document validation failed");
                _context.TransitionTo(new Draft());
            }
        }
    }

    /// <summary>
    /// Published state
    /// </summary>
    public class Published : State
    {
        public override void Publish(bool isAdmin)
        {
            Console.WriteLine("Document already published");
        }

        public override void Validate()
        {
            Console.WriteLine("Document is already published");
        }
    }

}

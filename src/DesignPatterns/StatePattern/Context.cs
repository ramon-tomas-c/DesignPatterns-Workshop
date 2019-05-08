using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class DocumentContext
    {
        // A reference to the current state of the Context.
        private State _state = null;

        public DocumentContext(State state)
        {
            this.TransitionTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Publish(bool isAdmin)
        {
            _state.Publish(isAdmin);
        }

        public void Validate()
        {
            _state.Validate();
        }
    }
}

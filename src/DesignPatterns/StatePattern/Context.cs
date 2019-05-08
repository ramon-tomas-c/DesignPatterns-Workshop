using System;

namespace StatePattern
{
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
                
            }

            // The Context allows changing the State object at runtime.
            public void TransitionTo(State state)
            {
               
            }

            public void Publish(bool isAdmin)
            {
               
            }

            public void Validate()
            {
               
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
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
        public class Draft 
        {
            

        }

        /// <summary>
        /// Pending validate state
        /// </summary>
        public class PendingValidate 
        {
           
        }

        /// <summary>
        /// Published state
        /// </summary>
        public class Published 
        {
           
        }

    }
}

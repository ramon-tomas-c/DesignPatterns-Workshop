using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// The Adapter makes the Adaptee's interface compatible with the Target's interface
    /// </summary>
    public class PlugConnectorAdapter : PlugConnector
    {
        private UKPlugSocket _socket;

        public PlugConnectorAdapter(UKPlugSocket socket)
        {
            _socket = socket;
        }

        public void Connect()
        {
            _socket.ProvideUKSocket();
        }
    }
}

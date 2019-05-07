using System;

namespace AdapterPattern
{
    /// <summary>
    /// Target interface used by the client code
    /// </summary>
    public interface PlugConnector
    {
        void Connect();
    }

    public interface UKPlugSocket
    {
        void ProvideUKSocket();
    }

    public class DefaultElectricalSocket 
    {
        
    }

    /// <summary>
    /// The Adaptee contains the new behaviour but its interface is incompatible
    /// </summary>
    public class UKElectricalSocket
    {
        
    }
}

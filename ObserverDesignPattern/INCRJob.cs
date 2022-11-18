using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface INCRJob
    {
        void RegisterObserver(IJobSeeker observer);
        void RemoveObserver(IJobSeeker observer);
        void NotifyObservers();
    }
}

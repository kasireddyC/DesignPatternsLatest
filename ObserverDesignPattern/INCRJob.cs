namespace ObserverDesignPattern
{
    public interface INCRJob
    {
        void RegisterObserver(IJobSeeker observer);
        void RemoveObserver(IJobSeeker observer);
        void NotifyObservers();
    }
}

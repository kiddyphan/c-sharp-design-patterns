namespace Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void NotifyByEmail(string news);
        void Notify();
    }
}
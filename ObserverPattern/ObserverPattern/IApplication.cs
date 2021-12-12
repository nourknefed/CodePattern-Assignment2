using ObserverPattern.observer;

namespace ObserverPattern
{
    public interface IApplication
    {
        IEmail Email { get; set; }
        IObserver Observer { get; set; }

        void Run();
    }
}
namespace ObserverPattern.observer
{
    public interface IEmail:ISubject
    {
         int EvenMinute { get; set; }
         string Check();
    }
}
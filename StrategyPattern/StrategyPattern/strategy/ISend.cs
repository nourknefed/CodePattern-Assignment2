namespace StrategyPattern.strategy
{
    public interface ISend
    {
        IMessage Message { get; set; }
        void SendMessage();
    }
}
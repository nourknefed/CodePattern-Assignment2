using StrategyPattern.strategy;

namespace StrategyPattern
{
    public interface IApplication
    {
        IEmail Email { get; set; }
        IFacebook FacebookMessage { get; set; }
        ISend Send { get; set; }
        ISMS SMS { get; set; }

        void Run();
    }
}
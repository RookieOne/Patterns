
namespace DecoratorPattern.NoDecoratorFramework
{
    /// <summary>
    /// New interface for Beverage with Sugar and Milk
    /// </summary>
    public interface INoDecoratorBeverage
    {
        string GetDescription();
        double GetPrice();

        bool HasMilk { get; }
        void AddMilk();

        bool HasSugar { get; }
        void AddSugar();
    }
}

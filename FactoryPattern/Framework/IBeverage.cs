
namespace FactoryPattern.Framework
{
    public interface IBeverage
    {
        BeverageType BeverageType { get; }

        string GetDescription();
        double GetPrice();
    }
}

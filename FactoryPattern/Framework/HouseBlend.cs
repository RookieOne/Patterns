
namespace FactoryPattern.Framework
{
    /// <summary>
    /// House Blend
    /// </summary>
    public class HouseBlend : IBeverage
    {
        #region IBeverage Members

        public BeverageType BeverageType
        {
            get { return BeverageType.HouseBlend; }
        }

        public string GetDescription()
        {
            return "House Blend";
        }

        public double GetPrice()
        {
            return 5d;
        }

        #endregion
    }
}

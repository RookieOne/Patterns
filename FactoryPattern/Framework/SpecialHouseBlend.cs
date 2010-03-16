
namespace FactoryPattern.Framework
{
    /// <summary>
    /// Exotic House Blend
    /// </summary>
    public class SpecialHouseBlend : IBeverage
    {
        #region IBeverage Members

        public BeverageType BeverageType
        {
            get { return BeverageType.HouseBlend; }
        }

        public string GetDescription()
        {
            return "Special House Blend";
        }

        public double GetPrice()
        {
            return 8d;
        }

        #endregion
    }
}

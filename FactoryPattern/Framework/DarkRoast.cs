
namespace FactoryPattern.Framework
{
    /// <summary>
    /// Normal Dark Roast
    /// </summary>
    public class DarkRoast : IBeverage
    {
        #region IBeverage Members

        public BeverageType BeverageType
        {
            get { return BeverageType.Roast; }
        }

        public string GetDescription()
        {
            return "Dark Roast";
        }

        public double GetPrice()
        {
            return 3d;
        }

        #endregion
    }
}



namespace FactoryPattern.Framework
{
    /// <summary>
    /// Exotic Amazon Roast
    /// </summary>
    public class AmazonRoast : IBeverage
    {
        #region IBeverage Members

        public BeverageType BeverageType
        {
            get { return BeverageType.Roast; }
        }

        public string GetDescription()
        {
            return "Amazon Roast";    
        }

        public double GetPrice()
        {
            return 10d;
        }

        #endregion
    }
}

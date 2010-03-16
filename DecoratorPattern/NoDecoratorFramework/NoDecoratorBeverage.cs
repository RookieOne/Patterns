using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.NoDecoratorFramework
{
    public abstract class NoDecoratorBeverage : INoDecoratorBeverage
    {
        #region Original IBeverage Methods

        public abstract string GetDescription();        

        public abstract double GetPrice();

        #endregion

        #region INoDecoratorBeverage Members

        protected string GetCondimentDescription()
        {
            string result = string.Empty;

            if (HasMilk)
                result += " with Milk";

            if (HasSugar)
                result += " with Sugar";

            return result;
        }

        protected double GetCondimentPrice()
        {
            double result = 0;

            if (HasMilk)
                result += .5d;

            if (HasSugar)
                result += .2d;

            return result;
        }

        public bool HasMilk { get; private set; }

        public void AddMilk()
        {
            HasMilk = true;
        }

        public bool HasSugar { get; private set; }

        public void AddSugar()
        {
            HasSugar = true;
        }

        #endregion
    }
}

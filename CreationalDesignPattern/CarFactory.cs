using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternBuilder
{

    #region Director Class
   public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetTopSpeed();
            builder.SetHorsePower();
            builder.SetImpressiveFeatures();
            return builder.GetCar();
        }

    }
    #endregion
}

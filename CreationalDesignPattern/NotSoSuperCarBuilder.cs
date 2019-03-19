using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternBuilder
{
    #region ConcreteBuilder1 Class
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetTopSpeed()
        {
            _car.TopSpeedMph = 100;
        }
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;

        }
        public override void SetImpressiveFeatures()
        {
            _car.MostImpressiveFeature = "Has Air conditioning";
        }
    }
    #endregion
}

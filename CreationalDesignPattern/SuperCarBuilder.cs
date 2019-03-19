using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternBuilder
{
    #region ConcreteBuilderClass2 
    class SuperCarBuilder : CarBuilder
    {
        public override void SetTopSpeed()
        {
            _car.TopSpeedMph = 600;
        }

        public override void SetHorsePower()
        {
            _car.HorsePower = 500;
        }

        public override void SetImpressiveFeatures()
        {
            _car.MostImpressiveFeature = "Can fly";
        }
    }
    #endregion

}

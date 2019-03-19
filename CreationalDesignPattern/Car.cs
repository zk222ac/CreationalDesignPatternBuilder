using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternBuilder
{
    #region Product

    // The Product Class
    public class Car
    {
        public int TopSpeedMph { get; set; }
        public int HorsePower { get; set; }
        public string MostImpressiveFeature { get; set; }
    }

    #endregion

}

using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatternBuilder
{
    #region Builder Class
    // The Builder Abstract Class
    public abstract class CarBuilder
    {
        // abstract car object 
        protected readonly  Car _car = new Car();
        // abstract methods -> set up new message stubs
        public abstract void SetTopSpeed();
        public abstract void SetHorsePower();
        public abstract void SetImpressiveFeatures();

        // Concrete GetCar method which return the current car object instance
        public virtual Car GetCar()
        {
            return _car;
        }
    }
    #endregion

}

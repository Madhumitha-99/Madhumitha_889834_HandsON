using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_DP_T03
{
    public interface MovableAdapter
    {
        double GetSpeed();
        double GetPrice();
    }
    
    public class MovableAdapterImpl : MovableAdapter
    {
        
        private Movable luxuryCars;
        public MovableAdapterImpl(Movable cars)
        {
            luxuryCars = cars;
        }
        public double GetSpeed()
        {
            return ConvertMPHtoKMPH(luxuryCars.GetSpeed());
        }
        private double ConvertMPHtoKMPH(double speed)
        {
            return speed * 1.60934;
        }
        public double GetPrice()
        {
            return ConvertUSDtoEuro(luxuryCars.GetPrice());
        }
        public double ConvertUSDtoEuro(double price)
        {
            return price * 0.84;
        }
    }
}

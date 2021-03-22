using System;
using System.Collections.Generic;
using System.Text;
using static PracticeCaseStudy_AbstractPattern.Program;

namespace PracticeCaseStudy_AbstractPattern
{
    public class CarClient
    {
        CarFactory carFactory;
        public CarClient(CarFactory car)
        {
            carFactory = car;
        }
        public void BuildMicroCar(Location location)
        {
            carFactory.MakeMicroCar(location, CarType.MICRO);
        }
        public void BuildMiniCar(Location location)
        {
            carFactory.MakeMiniCar(location, CarType.MINI);
        }
        public void BuildLuxuryCar(Location location)
        {
            carFactory.MakeMiniCar(location, CarType.LUXURY);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static PracticeCaseStudy_AbstractPattern.Program;

namespace PracticeCaseStudy_AbstractPattern
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);

    }
}

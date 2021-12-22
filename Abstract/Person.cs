using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
        public void Drive(SportCar car)
        {
            car.Drive();
        }

    }
}

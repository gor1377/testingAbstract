using System;

namespace Abstract
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new SportCar());
            person.Drive(new Car());
                                 
        }
    }
}

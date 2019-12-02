using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBio_30._11._2019
{
    class Personnel : ICar, IMotor, IPerson2, ICustomer
    {
        public string PersonnelID;
        Car Car1 = new Car();
        Motor Motor = new Motor();
        Person2 Person2 = new Person2();
        Customer Customer = new Customer();

    }
}

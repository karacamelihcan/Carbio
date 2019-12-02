using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBio_30._11._2019
{
    class Customer:Person1,ICustomer
    {
        public string Job;
        public int Licence_No;
        public int Licence_Type;
        public int Licence_Age;
        public int Customer_ID;
    }
}

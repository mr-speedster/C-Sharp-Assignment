using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    internal class Address
    {
        private string addressLine1;
        private string addressLine2;
        private string city;
        private int pincode;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int Pincode
        {
            get { return pincode; }
            set
            {
                if (value >= 0 && value <= 999999)
                {
                    pincode = value;
                }
                else
                {
                    pincode = 570010;
                }
            }
        }
        public Address()
        {

        }
        public Address(string addressLine1, string addressLine2, string city, int pincode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Pincode = pincode;
        }
    }
}

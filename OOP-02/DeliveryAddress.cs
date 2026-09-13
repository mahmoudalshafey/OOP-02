using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class DeliveryAddress
    {
        private string City { set; get; }
        private string Street { set; get; }
        private int buildingNumber { set; get; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.City = city;
            this.Street = street;
            this.buildingNumber = buildingNumber;
        }

        public void GetFullAddress()
        {
            Console.WriteLine($"City: {City}, Street: {Street}, Building Number: {buildingNumber}");
        }
    }
}

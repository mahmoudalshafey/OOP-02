using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}

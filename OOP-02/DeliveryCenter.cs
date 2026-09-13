using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class DeliveryCenter
    {
        private Shipment[] shipment = new Shipment[10];
        public DeliveryCenter() { }

        public Shipment this[int index]
        {
            set
            {
                if (index < 0 || index >= 10)
                {
                    return;
                }
                shipment[index] = value;
            }
            get
            {
                if (index > 0 && index < 10)
                {
                    return shipment[index];
                }
                return default;

            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i].TrackingCode02 == trackingCode)
                    {
                        return shipment[i];
                    }
                }
                return default;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < this.shipment.Length; i++)
            {
                if (this.shipment[i].TrackingCode02 == null)
                {
                    this.shipment[i] = shipment;
                    return true;
                }
            }
            return false;
        }
    }
}

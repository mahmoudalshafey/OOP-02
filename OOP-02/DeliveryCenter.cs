using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class DeliveryCenter
    {
        private Shipment[] shipment = new Shipment[20];

        public string CenterName;
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
                    if (shipment[i].TrackingCode == trackingCode)
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
                if (this.shipment[i].TrackingCode == null)
                {
                    this.shipment[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(Shipment shipment) {
            for (int i = 0; i < this.shipment.Length; i++)
            {
                if (this.shipment[i] == shipment)
                {
                    this.shipment[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i] != null)
                {
                    Console.WriteLine($"Tracking Code: {shipment[i].TrackingCode}");
                    Console.WriteLine($"Description: {shipment[i].Description}");
                    Console.WriteLine($"Weight: {shipment[i].Weight}");
                    Console.WriteLine($"Delivery Fee: {shipment[i].DeliveryFee}");
                    Console.WriteLine($"Estimated Cost: {shipment[i].EstimatedCost}"); 
                }
            }
        }


    }
}

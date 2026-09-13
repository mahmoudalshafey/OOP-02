using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        private string destination;

        public double Destination { get; set; }

        public string TrackingCode
        {
            get;
            set
            {
                if (trackingCode.Length != 0 || trackingCode != null)
                    trackingCode = value;
            }
        }
        public string Description
        {
            get;
            set
            {
                if (description.Length != 0 || description != null)
                    description = value;
            }
        }
        public decimal Weight
        {
            get;
            set
            {
                if (weight > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get;
            set
            {
                if (deliveryFee > 0)
                    deliveryFee = value;
            }
        }
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
        }

        public Shipment(string description = "Unknown", double weight = 1, double deliveryFee = 50)
        {

        }

        public Shipment(string trackingCode , string description, decimal weight, decimal deliveryFee, string destination)
        {
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            this.trackingCode = trackingCode;
            this.destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {trackingCode}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Delivery Fee: {deliveryFee}");
            Console.WriteLine($"Destination: {destination}");
        }
    }
}

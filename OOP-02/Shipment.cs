using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;

        private string destination;

        public double Destination01 { get; set; }

        public string TrackingCode01
        {
            get;
            set
            {
                if (trackingCode.Length != 0 || trackingCode != null)
                    trackingCode = value;
            }
        }
        public string Description01
        {
            get;
            set
            {
                if (description.Length != 0 || description != null)
                    description = value;
            }
        }
        public double Weight01
        {
            get;
            set
            {
                if (weight > 0)
                    weight = value;
            }
        }

        public double DeliveryFee01
        {
            get;
            set
            {
                if (deliveryFee > 0)
                    deliveryFee = value;
            }
        }

        public string TrackingCode02
        {
            get { return trackingCode; }

        }

        public string Description02
        {
            get { return description; }
            set { description = value; }
        }

        public double Weight02
        {
            get { return weight; }
            set { weight = value; }
        }

        public double DeliveryFee02 { get; private set; }

        public string Destination02 { get; set; }

        public double EstimatedCost
        {
            get
            {
                return DeliveryFee01 + (Weight01 * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
        }

        public Shipment(string description = "Unknown", double weight = 1, double deliveryFee = 50)
        {

        }

        public Shipment(string description, double weight, double deliveryFee, string trackingCode, string destination)
        {
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            this.trackingCode = trackingCode;
            this.destination = destination;
        }

        public void UpdateDeliveryFee(double newFee)
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

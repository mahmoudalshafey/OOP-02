using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class InternationalShipment : Shipment
    {
        public string DestinationCountry {
            get;
            set {
                if (DestinationCountry.Length != 0 || DestinationCountry != null)
                    DestinationCountry = value;
            } 
        }
        public decimal CustomsFee
        {
            get;
            set
            {
                if (CustomsFee > 0)
                    CustomsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { 
                return base.EstimatedCost + CustomsFee;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class ExpressShipment : Shipment       
    {
        public decimal ExtraFee
        { 
            get;

            set {
                if (value > 0)
                    ExtraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { 
                
                return base.EstimatedCost + ExtraFee;
            }
        }


    }
}

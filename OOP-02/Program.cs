namespace OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ques 1
            // a - class can inherit from another class but struct cannot inherit from another struct or class
            //   - class is reference type and struct is value type
            //   - class can have a default constructor but struct cannot have a default constructor

            // b - because struct is suitable for small data structures that have value semantics, while class is suitable for larger, more complex objects that require reference semantics.

            #endregion

            #region Ques 2
            // a - Shipment
            // b - ExpressShipment
            // c - trackingCode.
            // d - to reduce the code & make maintanable . 
            #endregion

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.WriteLine("Enter the Center Name: ");
            string centerName = Console.ReadLine();
            deliveryCenter.CenterName = centerName;

            Shipment shipment = new Shipment();
            deliveryCenter.AddShipment(shipment);

            StandardShipment standardShipment = new StandardShipment();
            deliveryCenter.AddShipment(standardShipment);
            ExpressShipment expressShipment = new ExpressShipment();
            deliveryCenter.AddShipment(expressShipment);
            InternationalShipment internationalShipment = new InternationalShipment();
            deliveryCenter.AddShipment(internationalShipment);

            //--------------StandardShipment----------------//

            Console.WriteLine("Enter Tracking Code: ");
            string trackingCode01 = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            string description01 = Console.ReadLine();

            Console.WriteLine("Enter Weight: ");
            decimal weight01;
            Decimal.TryParse(Console.ReadLine(), out weight01);

            Console.WriteLine("Enter Delivery Fee: ");
            decimal deliveryFee01;
            Decimal.TryParse(Console.ReadLine(), out deliveryFee01  );

            decimal estimatedCost = standardShipment.EstimatedCost;

            standardShipment = new StandardShipment 
            {
                TrackingCode = trackingCode01,
                Description = description01,
                Weight = weight01,
                DeliveryFee = deliveryFee01 ,
                

            };

            //--------------ExpressShipment----------------//


            Console.WriteLine("Enter Tracking Code: ");
            string trackingCode02 = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            string description02 = Console.ReadLine();

            Console.WriteLine("Enter Weight: ");
            decimal weight02;
            Decimal.TryParse(Console.ReadLine(), out weight02);

            Console.WriteLine("Enter Delivery Fee: ");
            decimal deliveryFee02;
            Decimal.TryParse(Console.ReadLine(), out deliveryFee02);

            Console.WriteLine("Enter ExtraFee: ");
            decimal extraFee;
            Decimal.TryParse(Console.ReadLine(), out extraFee );

            expressShipment = new ExpressShipment
            {
                TrackingCode = trackingCode02,
                Description = description02,
                Weight = weight02,
                DeliveryFee = deliveryFee02,
                ExtraFee = extraFee
            };

            //--------------InternationalShipment----------------//

            Console.WriteLine("Enter Tracking Code: ");
            string trackingCode03 = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            string description03 = Console.ReadLine();

            Console.WriteLine("Enter Weight: ");
            decimal weight03;
            Decimal.TryParse(Console.ReadLine(), out weight03);

            Console.WriteLine("Enter Delivery Fee: ");
            decimal deliveryFee03;
            Decimal.TryParse(Console.ReadLine(), out deliveryFee03);

            Console.WriteLine("Enter CustomsFee: ");
            decimal customsFee;
            Decimal.TryParse(Console.ReadLine(), out customsFee );

            Console.WriteLine("Enter DestinationCountry: ");
            string destinationCountry = Console.ReadLine();

            internationalShipment = new InternationalShipment
            {
                TrackingCode = trackingCode03,
                Description = description03,
                Weight = weight03,
                DeliveryFee = deliveryFee03,
                CustomsFee = customsFee,
                DestinationCountry = destinationCountry
            };

            deliveryCenter.PrintAllShipments();

            Shipment searchedShipment = deliveryCenter["SH002"];
            Console.WriteLine(searchedShipment);

            deliveryCenter.RemoveShipment(searchedShipment);

            deliveryCenter.PrintAllShipments();



        }
    }
}

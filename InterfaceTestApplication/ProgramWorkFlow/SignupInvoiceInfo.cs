using InterfaceTestApplication.Services;
using InterfaceTestApplication.Entities;
using System;
using System.Globalization;

namespace InterfaceTestApplication.ProgramWorkFlow
{
    class SignupInvoiceInfo
    {

        public static RentalService InvoiceRegistration()               
        {
            double hour = PricePerHour();

            double day = PricePerDay();

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            return rentalService;
        }

        private static double PricePerHour()
        {
            Console.Write("Enter price per hour: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        private static double PricePerDay()
        {
            Console.Write("Enter price per hour: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}

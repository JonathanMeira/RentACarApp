using System;
using InterfaceTestApplication.Entities;

namespace InterfaceTestApplication.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            TaxService = taxService;
        }

        public void ProcessInvoice(CarRental car)
        {
            TimeSpan totalDuration = car.Finish.Subtract(car.Start);

            double basicPayment;
            double tax;

            if (totalDuration.Hours <= 12.0)
            {
                basicPayment = Math.Ceiling(totalDuration.TotalHours) * PricePerHour;
            }
            else 
            {
                basicPayment = PricePerDay * Math.Ceiling(totalDuration.TotalDays);            
            }

            tax = TaxService.Tax(basicPayment);

            car.Invoice = new Invoice(basicPayment, tax);

        }
    
    }
}

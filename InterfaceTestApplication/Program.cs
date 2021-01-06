using System;
using InterfaceTestApplication.Entities;
using InterfaceTestApplication.ProgramWorkFlow;
using InterfaceTestApplication.Services;

namespace InterfaceTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarRental newCar = SignupRentalInfo.CarRegistration();

                RentalService rentalService = SignupInvoiceInfo.InvoiceRegistration();

                rentalService.ProcessInvoice(newCar);

                Console.WriteLine("Invoice:");
                Console.WriteLine($"{newCar.Invoice}");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

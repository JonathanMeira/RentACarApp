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

            CarRental newCar = SignupRentalInfo.CarRegistration();

            RentalService rentalService = SignupInvoiceInfo.InvoiceRegistration();

            rentalService.ProcessInvoice(newCar);

            Console.WriteLine("Invoice:");
            Console.WriteLine($"{newCar.Invoice}");
            
        }
    }
}

using System;
using InterfaceTestApplication.Entities;
using System.Globalization;

namespace InterfaceTestApplication.ProgramWorkFlow
{
    class SignupRentalInfo
    {
        public static CarRental CarRegistration()
        {
            Console.WriteLine("Enter rentar data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            DateTime start = PickUpDate();
            DateTime finish = ReturnDate();
            CarRental car = new CarRental(start, finish, new Vehicle(carModel) );

            return car; 
        }

        private static DateTime PickUpDate() 
        {
            Console.Write("PickUp(dd/MM/yyyy HH:mm): ");

            DateTime pickUp = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            return pickUp;
        }

        private static DateTime ReturnDate()
        {
            Console.Write("Return(dd/MM/yyyy HH:mm): ");

            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            return finish;
        }

    }
}

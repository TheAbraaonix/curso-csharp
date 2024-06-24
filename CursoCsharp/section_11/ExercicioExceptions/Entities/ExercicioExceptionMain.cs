using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_11.ExercicioExceptions.Exceptions;

namespace CursoCsharp.section_11.ExercicioExceptions.Entities
{
    internal class ExercicioExceptionMain
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation.ToString());
                Console.WriteLine();

                Console.WriteLine("Enter the data to update the reservation:");
                Console.Write("Check-in date: ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}

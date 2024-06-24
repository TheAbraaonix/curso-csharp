using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_11.ExercicioExceptions.Exceptions;

namespace CursoCsharp.section_11.ExercicioExceptions.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after Check-in date.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates must be future dates");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after Check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = CheckOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", Check-in: " + CheckIn.ToString("dd/MM/yyyy") +
                ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }
    }
}

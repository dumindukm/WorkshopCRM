using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core.Models
{
    public class BookingCreator : IBookingCreator
    {
        public BookingCreator()
        {

        }
        public BookingBase CreateBooking(IPriceCalculator priceCalculator, int workshopId, int serviceId, int vehicleId)
        {
            BookingBase booking = new Booking(priceCalculator, workshopId, serviceId, vehicleId);
            SetVehicleDetails(booking);

            return booking;
        }

        private void SetVehicleDetails(BookingBase booking)
        {
            booking.SetVehicle(new Vehicle());
        }
    }
}

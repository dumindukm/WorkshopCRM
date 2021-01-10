using CRM_Core.Models;
using CRM_Core.services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core.services.concrete
{
    public class BookingService : IBookingService
    {
        private readonly IBookingCreator bookingCreator;

        public BookingService(IBookingCreator bookingCreator)
        {
            this.bookingCreator = bookingCreator;
            var t = new TestClass(this.bookingCreator);
        }

        public BookingBase CreateBooking(int workshopId, int serviceId, int vehicleId)
        {
            return this.bookingCreator.CreateBooking(new BoPriceCalculator() , workshopId , serviceId ,vehicleId);
        }
    }

    public class TestClass
    {
        private readonly IBookingCreator bookingCreator;
        public TestClass(IBookingCreator bookingCreator)
        {
            //var s = bookingCreator.GeTime()
            this.bookingCreator = bookingCreator;
        }
    }
}

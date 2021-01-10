using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core.services.interfaces
{
    public interface IBookingService
    {
        BookingBase CreateBooking(int workshopId, int serviceId, int vehicleId);
    }
}

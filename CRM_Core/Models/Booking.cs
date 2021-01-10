using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core
{
    public class Booking : BookingBase
    {
        public Booking(IPriceCalculator priceCalculator, int workshopId, int serviceId, int vehicleId) :base(priceCalculator, workshopId, serviceId, vehicleId)
        {

        }
        

        public override decimal CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}
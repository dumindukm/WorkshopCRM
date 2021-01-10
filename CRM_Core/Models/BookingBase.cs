using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core
{
    public abstract class BookingBase
    {
        protected BookingBase(IPriceCalculator priceCalculator, int workshopId, int serviceId, int vehicleId )
        {
            this.priceCalculator = priceCalculator;
        }

        public int BookingId
        {
            get;
            private set;
        }

        public int BookingNo
        {
            get;
            private set;
        }

        public IPriceCalculator priceCalculator
        {
            get ;
            private set;
            
        }

        internal void SetVehicle(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
        }

        public int WorkshopId { get; set; }
        public Workshop Workshop
        {
            get;
            private set;
        }

        public int VehicleId { get; private set; }
        public Vehicle Vehicle
        {
            get;
            private set;
        }

        public int VehicleServiceId { get; private set; }
        public VehicleServiceBase VehicleServiceBase
        {
            get;
            private set;
        }

        public abstract decimal CalculatePrice();
        
    }
}
namespace CRM_Core.Models
{
    public interface IBookingCreator
    {
        BookingBase CreateBooking(IPriceCalculator priceCalculator, int workshopId, int serviceId, int vehicleId);
    }
}
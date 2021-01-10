
using System;
using System.Threading.Tasks;
using CRM_Core;
using CRM_Core.Models;
using CRM_Core.services.concrete;
using CRM_Core.services.interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkshopCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IBookingService, BookingService>();
            collection.AddScoped<IBookingCreator, BookingCreator>();
            collection.AddScoped<IPriceCalculator, BoPriceCalculator>();
            // ...    
            // Add other services    
            // ...    
            IServiceProvider serviceProvider = collection.BuildServiceProvider();
            var sample1Service = serviceProvider.GetService<IBookingService>();
            var booking = sample1Service.CreateBooking(1, 2, 3);
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
                //}


            }
        }

    }
}

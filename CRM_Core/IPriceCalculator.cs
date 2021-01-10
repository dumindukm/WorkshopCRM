using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Core
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice();
    }
}
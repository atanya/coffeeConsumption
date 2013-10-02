using System;

namespace CoffeeConsumption.Models
{
    public class Consumption
    {
        public int UserId { get; set; }

        public int CupId { get; set; }

        public DateTimeOffset BeverageTime { get; set; }
    }
}
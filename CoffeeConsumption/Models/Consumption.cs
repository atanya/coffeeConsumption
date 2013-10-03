using System;

namespace CoffeeConsumption.Models
{
    public class Consumption
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CupId { get; set; }

        public DateTimeOffset BeverageTime { get; set; }

        public virtual Cup Cup { get; set; }

        public virtual User User { get; set; } 
    }
}
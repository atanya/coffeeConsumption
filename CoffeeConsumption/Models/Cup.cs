using System.Collections.Generic;

namespace CoffeeConsumption.Models
{
    public class Cup
    {
        public int Id { get; set; }

        public BeverageType Beverage { get; set; }

        public virtual ICollection<Consumption> Consumptions { get; set; }
    }

    public enum BeverageType
    {
        Coffee,
        Tea,
        Juice
    }
}
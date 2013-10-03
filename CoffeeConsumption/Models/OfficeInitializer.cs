using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CoffeeConsumption.Models
{
    public class OfficeInitializer : DropCreateDatabaseIfModelChanges<OfficeContext> 
    {
        protected override void Seed(OfficeContext context)
        {
            var cups = new List<Cup>
                {
                    new Cup {Beverage = BeverageType.Coffee},
                    new Cup {Beverage = BeverageType.Tea},
                    new Cup {Beverage = BeverageType.Juice}
                };
            cups.ForEach(s => context.Cups.Add(s));
            context.SaveChanges();

            var users = new List<User>
                {
                    new User {Name = "Tanya", Email = "t.arkhipova@svitla.com", Password = "1"},
                    new User {Name = "Igor", Email = "i.kesler@svitla.com", Password = "1"},
                    new User {Name = "Sasha", Email = "a.volkov@svitla.com", Password = "1"}
                };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var consumptions = new List<Consumption>
                {
                    new Consumption {UserId = 1, CupId = 1, BeverageTime = DateTime.Now.AddDays(-1)},
                    new Consumption {UserId = 1, CupId = 2, BeverageTime = DateTime.Now.AddMinutes(-10)},
                    new Consumption {UserId = 2, CupId = 3, BeverageTime = DateTime.Now.AddDays(-2)}
                };
            consumptions.ForEach(s => context.Consumptions.Add(s));
            context.SaveChanges();
        }
    }
}
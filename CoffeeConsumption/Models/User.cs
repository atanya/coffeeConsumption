using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeConsumption.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Login is required")]
        [EmailAddress(ErrorMessage = "Login should me a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public virtual ICollection<Consumption> Consumptions { get; set; }
    }
}
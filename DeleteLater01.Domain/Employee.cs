using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DeleteLater01.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Remote("AddressValidation", "Home", AdditionalFields = "Name", ErrorMessage = "Invalid Address")]
        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShop.ViewModels
{
    public class MyAccount
    {
        [Key]
        public int LoginId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password didn't matched")]
        public string Password { get; set; }
    }
}

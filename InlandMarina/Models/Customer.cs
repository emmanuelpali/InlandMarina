﻿using System.ComponentModel.DataAnnotations;

namespace InlandMarina.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Display(Name = "Phone (xxx-xxx-xxxx)")]
        [Required(ErrorMessage = "You must provide a phone number")]
        [RegularExpression(@"^([0-9]{3})-([0-9]{3})-([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [StringLength(15)]
        public string? Phone { get; set; }

        [Required]
        [StringLength(30)]
        public string? City { get; set; }

        
        // navigation property
        public virtual ICollection<Lease>? Leases { get; set; }
    }

}

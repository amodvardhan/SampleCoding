using System;
using System.ComponentModel.DataAnnotations;

namespace SampleCoding.DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Username { get; set; }

        [Required]
        [MaxLength(150)]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}

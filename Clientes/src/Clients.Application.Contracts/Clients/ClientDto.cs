using JetBrains.Annotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Clients.Clients
{
    public class ClientDto
    {
        [Required]
        public string Identification { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Gender { get; set; }
        [CanBeNull]
        public string MobileNumber { get; set; }
        [CanBeNull]
        public string Email { get; set; }
    }
}

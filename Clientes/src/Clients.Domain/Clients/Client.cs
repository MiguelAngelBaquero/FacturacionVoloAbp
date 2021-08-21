using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Clients.Clients
{
    public class Client : FullAuditedAggregateRoot<int>
    {
        public string Identification { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        protected Client()
        {
        }
        public Client(string identification, string lastname, string firstname, DateTime birthdate, string mobilenumber, string email)
        {
            Identification = identification;
            Lastname = lastname;
            FirstName = firstname;
            Birthdate = birthdate;
            MobileNumber = mobilenumber;
            Email = email;
        }

    }
}

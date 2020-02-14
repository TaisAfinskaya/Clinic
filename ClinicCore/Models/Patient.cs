using System;

namespace ClinicCore.Models
{
    public class Patient
    {

        public string Id { get; set; }
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public DateTime DateBth { get; set; }


        public string GetFullName => $"{FirstName} - {LastName} - {Patronimic} - {Id}";
    }
}

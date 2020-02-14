namespace ClinicCore.Models
{
    // Модель Врача
    public class Doctor
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Отчество
        public string Patronimic { get; set; }
        public string Specialization { get; set; }

        public string Position { get; set; }

        public string GetFullName => $"{FirstName} - {LastName} - {Patronimic} - {Id}";
    }
}

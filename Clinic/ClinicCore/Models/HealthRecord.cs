namespace ClinicCore.Models
{
    public class HealthRecord
    {
        public string Id { get; set; }
        public string Diagnosis { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public bool IsAmbulance { get; set; }

        public bool IsCanContinueWork { get; set; }
        public int CountDayWithoutWork { get; set; }
        public bool IsDispencary { get; set; }

        public string Notes { get; set; }
    }
}

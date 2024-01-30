namespace HealthCareAuthorization.Models
{
    public class Professional
    {
        public string Name { get; set; }

        public string NumberRegistry { get; set; }

        public string MedicalSpecialty { get; set; }

        public Professional()
        {                
        }

        public Professional(string name, string numberRegistry, string medicalSpecialty)
        {
            Name = name;
            NumberRegistry = numberRegistry;
            MedicalSpecialty = medicalSpecialty;
        }
    }
}

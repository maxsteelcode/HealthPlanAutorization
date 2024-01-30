namespace HealthCareAuthorization.Models
{
    public class MedicalProcedure
    {
        public  string Description { get; set; }

        public int ProcedureId  { get; set; }

        public MedicalProcedure()
        {
            
        }

        public MedicalProcedure(string description, int procedureId)
        {
            Description = description;
            ProcedureId = procedureId;
        }

    }
}

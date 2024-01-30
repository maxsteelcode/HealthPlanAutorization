namespace HealthCareAuthorization.Models
{
    public class MedicalProcedureRequest
    {
        public MedicalProcedure MedicalProcedure { get; set; }

        public short Quantity { get; set; }

        public MedicalProcedureRequest(MedicalProcedure medicalProcedure, short quantity)
        {
            MedicalProcedure = medicalProcedure;
            Quantity = quantity;
        }
    }
}

namespace HealthCareAuthorization.Models
{
    public class MedicalProcedureResponse
    {
        public MedicalProcedure MedicalProcedure { get; set; }

        public short Quantity { get; set; }

        public bool IsAuthorized { get; set; }

        public string NotAuthorizedReason { get; set; }

        public MedicalProcedureResponse(MedicalProcedure medicalProcedure, short quantity, bool isauthorized, string notAuthorizedReason)
        {
            MedicalProcedure = medicalProcedure;
            Quantity = quantity;
            IsAuthorized = isauthorized;
            NotAuthorizedReason = notAuthorizedReason;
        }
    }
}

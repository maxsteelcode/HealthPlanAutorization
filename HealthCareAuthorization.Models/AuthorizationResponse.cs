namespace HealthCareAuthorization.Models
{
    public class AuthorizationResponse
    {
        public Guid RequestId { get; set; }

        public int AuthorizationId { get; set; }

        public List<MedicalProcedureResponse> MedicalProceduresResponse { get; set; }

        public AuthorizationResponse(Guid requestId, int authorizationId, List<MedicalProcedureResponse> medicalProceduresResponse)
        {
            RequestId = requestId;
            AuthorizationId = authorizationId;
            MedicalProceduresResponse = medicalProceduresResponse;
        }
    }
}

namespace HealthCareAuthorization.Models
{
    public class RequestAuthorization
    {
        public Guid RequestId { get; set; }

        public Pacient Pacient { get; set; }

        public List<MedicalProcedureRequest> MedicalProceduresRequested { get; set; }

        public Professional Professional { get; set; }

        public Diagnostics Diagnostics { get; set; }

        public RequestAuthorization(Guid requestid, Pacient pacient, 
            List<MedicalProcedureRequest> medicalProceduresRequested, 
            Professional professional, Diagnostics diagnostics)
        {
            RequestId = requestid;
            Pacient = pacient;
            MedicalProceduresRequested = medicalProceduresRequested;
            Professional = professional;
            Diagnostics = diagnostics;
        }

    }
}

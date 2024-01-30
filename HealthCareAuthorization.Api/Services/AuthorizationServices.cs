using HealthCareAuthorization.Models;
using System.Net;

namespace HealthCareAuthorization.Api.Services
{
    public class AuthorizationServices
    {
        private static List<AuthorizationResponse> _authorizationResponses;

        public AuthorizationServices()
        {
            _authorizationResponses = new List<AuthorizationResponse>();
            MockAuthorizationResponse();
        }        

        public async Task<AuthorizationResponse> PostAuthorizationRequestAsync(RequestAuthorization requestAuthorization)
        {
            return await Task.Run(() =>
            {
                return _authorizationResponses.FirstOrDefault();
            });
        }
                
        public async Task<AuthorizationResponse> GetAuthorizationResponseAsync(int authorizationId)
        {
            return await Task.Run(() =>
            {
                return _authorizationResponses.FirstOrDefault(a => a.AuthorizationId == authorizationId);
            });
        }

        public async Task DeleteAuthorizationResponseAsync(int authorizationId)
        {
            await Task.Run(() =>
            {
                var authorizationResponse = _authorizationResponses.FirstOrDefault(a => a.AuthorizationId == authorizationId);
                if (authorizationResponse != null)
                {
                    _authorizationResponses.Remove(authorizationResponse);
                    return;
                }
                throw new InvalidOperationException("Invalid number of AuthorizationId");// replace by custom exception
            });
        }

        private void MockAuthorizationResponse()
        {
            MedicalProcedure medicalProcedureHIV = new MedicalProcedure("HIV Exame", 101);
            MedicalProcedure medicalProcedureHDL = new MedicalProcedure("HDL Exame", 201);
            MedicalProcedureResponse medicalProcResponseHIV = new MedicalProcedureResponse(medicalProcedureHIV, 1, true, string.Empty);
            MedicalProcedureResponse medicalProcResponseHDL = new MedicalProcedureResponse(medicalProcedureHDL, 1, true, string.Empty);
            List<MedicalProcedureResponse> medicalProceduresResponseList = new List<MedicalProcedureResponse>();
            medicalProceduresResponseList.Add(medicalProcResponseHIV);
            medicalProceduresResponseList.Add(medicalProcResponseHDL);
            _authorizationResponses.Add(new AuthorizationResponse(Guid.NewGuid(), 223344, medicalProceduresResponseList));
        }
    }
}

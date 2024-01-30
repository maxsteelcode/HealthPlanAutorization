using HealthCareAuthorization.Api.Services;
using HealthCareAuthorization.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HealthCareAuthorization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private static AuthorizationServices _authorizationServices;

        public AuthorizationController()
        {
            _authorizationServices = new AuthorizationServices();
        }

        [HttpGet("{authorizationId}", Name = "Get")]
        public async Task<ActionResult> GetAsync(int authorizationId)
        {
            var authorizationResponse = await _authorizationServices.GetAuthorizationResponseAsync(authorizationId);

            if (authorizationResponse == null)
            {
                return NotFound();
            }

            return Ok(authorizationResponse);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] RequestAuthorization requestAuthorization)
        {
            var authorizationResponse = await _authorizationServices.PostAuthorizationRequestAsync(requestAuthorization);

            if (authorizationResponse == null)
            {
                return NotFound();
            }

            return CreatedAtAction("Get", new { authorizationId = authorizationResponse.AuthorizationId }, authorizationResponse);
            //return CreatedAtRoute("Get", new { authorizationId = authorizationResponse.AuthorizationId }, authorizationResponse);
        }

        [HttpDelete("{authorizationId}")]
        public async Task<ActionResult> DeleteAsync(int authorizationId)
        {
            try
            {
                await _authorizationServices.DeleteAuthorizationResponseAsync(authorizationId);
                return Ok();
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal Server Error");// is really necessary?
            }
        }

    }
}

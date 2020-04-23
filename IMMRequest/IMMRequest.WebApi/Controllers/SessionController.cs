using System;
using Microsoft.AspNetCore.Mvc;
using IMMRequest.BusinessLogic.Interface;
using IMMRequest.WebApi.Models;

namespace IMMRequest.WebApi
{
    
    [ApiController]
    [Route("api/sessions")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionLogic sessionLogic;

        public SessionController(ISessionLogic _sessionLogic)
        {
            this.sessionLogic = _sessionLogic;
        }

        [HttpPost]
        public IActionResult Login([FromBody]LoginModel loginModel)
        {
            try
            {
                return Ok(this.sessionLogic.Login(loginModel.Email, loginModel.Password));
            }
            catch(Exception)
            {
                return BadRequest("Error credentials");
            }
        }
    }
}
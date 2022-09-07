
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UndergraduateResearchPortal.Web.Models;

namespace UndergraduateResearchPortal.Web.Api
{
    [Route("api/LoginService")]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class LoginServiceController : Controller
    {
        protected UndergraduateResearchPortal.Data.Services.ILoginService Service { get; }

        public LoginServiceController(UndergraduateResearchPortal.Data.Services.ILoginService service)
        {
            Service = service;
        }

        /// <summary>
        /// Method: Login
        /// </summary>
        [HttpPost("Login")]
        [AllowAnonymous]
        public virtual async Task<ItemResult> Login(string email, string password)
        {
            var _methodResult = await Service.Login(email, password);
            var _result = new ItemResult(_methodResult);
            return _result;
        }

        /// <summary>
        /// Method: GetToken
        /// </summary>
        [HttpPost("GetToken")]
        [AllowAnonymous]
        public virtual async Task<ItemResult<dynamic>> GetToken(string email, string password)
        {
            var _methodResult = await Service.GetToken(email, password);
            var _result = new ItemResult<dynamic>(_methodResult);
            _result.Object = _methodResult.Object;
            return _result;
        }

        /// <summary>
        /// Method: Logout
        /// </summary>
        [HttpPost("Logout")]
        [AllowAnonymous]
        public virtual async Task<ItemResult> Logout()
        {
            var _methodResult = await Service.Logout();
            var _result = new ItemResult(_methodResult);
            return _result;
        }

        /// <summary>
        /// Method: CreateAccount
        /// </summary>
        [HttpPost("CreateAccount")]
        [AllowAnonymous]
        public virtual async Task<ItemResult> CreateAccount(string firstName, string lastName, string email, string password)
        {
            var _methodResult = await Service.CreateAccount(firstName, lastName, email, password);
            var _result = new ItemResult(_methodResult);
            return _result;
        }

        /// <summary>
        /// Method: ChangePassword
        /// </summary>
        [HttpPost("ChangePassword")]
        [Authorize]
        public virtual async Task<ItemResult> ChangePassword(string currentPassword, string newPassword)
        {
            var _methodResult = await Service.ChangePassword(User, currentPassword, newPassword);
            var _result = new ItemResult(_methodResult);
            return _result;
        }

        /// <summary>
        /// Method: IsLoggedIn
        /// </summary>
        [HttpPost("IsLoggedIn")]
        [AllowAnonymous]
        public virtual ItemResult IsLoggedIn()
        {
            var _methodResult = Service.IsLoggedIn(User);
            var _result = new ItemResult(_methodResult);
            return _result;
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sepidar.Infrastructure.Base;
using Sepidar.api.Extentions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
//using Sepidar.Api.Controllers;

namespace Sepidar.api.Base
{
    [Authorize]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {

        protected string AccessToken => Request.Headers.ContainsKey("Authorization")
            ? Request.Headers["Authorization"].ToString().Split(" ")[1]
            : string.Empty;

        protected virtual string UserName => GetClaim<string>(ClaimTypes.GivenName);
        protected virtual Guid UserId => GetClaim<Guid>("id");
        protected virtual string Name => GetClaim<string>(ClaimTypes.Name);

        /// <summary>
        /// شناسه کسب و کار فعلی از توکن گرفته می شود
        /// </summary>
        protected virtual Guid BusinessId => GetBusinessId();

        private Guid GetBusinessId()
        {
            var businessId = GetClaim<Guid>("businessId");
            //Mapper.BusinessId = businessId;
            return businessId;
        }

        protected ApiControllerBase()
        {
        }
        #region responses 
        [NonAction]
        public BadRequestObjectResult BadRequest(string message)
        {
            return BadRequest(new { Message = message });
        }

        [NonAction]
        public NotFoundObjectResult NotFound(string message)
        {
            return NotFound(new { Message = message });
        }

        [NonAction]
        protected virtual IActionResult OkResult()
        {
            return this.OkResult("", null);
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message)
        {
            return this.OkResult(message, null);
        }

        [NonAction]
        protected virtual IActionResult OkContentResult(object content)
        {
            return this.OkResult("", content);
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message, object content)
        {
            return Ok(new ResponseMessage(message, content));
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message, object content, int total)
        {
            return Ok(new ResponseMessage(message, content, total));
        }
        #endregion

        public T GetClaim<T>(string claimType)
        {
            try
            {
                var stream = this.AccessToken;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(stream);
                var tokenS = handler.ReadToken(stream) as JwtSecurityToken;

                var claim = tokenS.Claims.FirstOrDefault(claim => claim.Type == claimType).Value;
                var result = claim.ToType<T>();
                return result;
            }
            catch (System.Exception ex)
            {
                if (this.ControllerContext.HttpContext.User.Claims == null)
                    throw new ManagedException("دسترسی نامعتبر، دوباره تلاش کنید.");

                throw new ManagedException("دسترسی نامعتبر", ex);
            }
        }

        [NonAction]
        protected virtual async Task<IActionResult> HandleRequest<TContent>(Func<Task<TContent>> action, string message = "با موفقیت انجام شد", RequestConfig config = null)
        {
            try
            {
                config ??= RequestConfig.Default;

                var content = await action.Invoke();

                if (config.ReturnActionOutputOnly)
                    return (IActionResult)content;

                return config.ReturnContentOnly ? Ok(content) : OkResult(message, content);
            }
            catch (ManagedException exception)
            {
                throw new ManagedException(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine();
                Console.WriteLine(exception.ToString());
                Console.WriteLine("######## ^^^ ########");
                throw new Exception(exception.Message);
            }
        }

        public class RequestConfig
        {
            public static RequestConfig Default => new RequestConfig();

            /// <inheritdoc />
            public RequestConfig(bool returnContentOnly = false)
            {
                ReturnContentOnly = returnContentOnly;
            }

            public bool ReturnContentOnly { get; set; }

            public bool ReturnActionOutputOnly { get; set; }
        }
    }
}

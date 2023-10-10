using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    /// <summary>
    /// Modifiying the Route because Creating User and Login USer 
    /// will be HttpPost methods
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        SecurityServices service;

        /// <summary>
        /// Iject the secuity Service
        /// </summary>
        /// <param name="service"></param>
        public AuthController(SecurityServices service)
        {
            this.service = service;
        }

        /// <summary>
        /// http://localhost:PORT/api/Auth/register
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("register")]
        public async Task<SecureResponse> Register(RegisterUser user)
        {
            SecureResponse response = new SecureResponse();
            try
            {
                response = await service.RegisterUserAsync(user);
            }
            catch (Exception ex)
            { 
                response.Message = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// http://localhost:PORT/api/Auth/login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("login")]
        public async Task<SecureResponse> Login(LoginUser user)
        {
            SecureResponse response = new SecureResponse();
            try
            {
                response = await service.AuthUser(user);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        [HttpPost]
        [ActionName("createrole")]
        public async Task<SecureResponse> CreateRole(RoleData role)
        { 
            SecureResponse response = new SecureResponse();
            try
            {
                response = await service.CreateRoleAsync(role);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }
            return response;
        }

        [HttpPost]
        [ActionName("addroletouser")]
        public async Task<SecureResponse> AddRoleToUser(UserRole role)
        {
            SecureResponse response = new SecureResponse();
            try
            {
                response = await service.AddRoleToUserAsync(role);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }
            return response;
        }

    }
}

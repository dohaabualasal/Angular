
using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtAuthController : Controller
    {/*

        private readonly IJwtAuthServices JwtAuthService;
        private UserManager<Customer> _userManager;
        private SignInManager<Customer> _signInManager;


        public JwtAuthController(IJwtAuthServices _jwtUserAuthService, UserManager<Customer> userManager, SignInManager<Customer> signInManager)
        {
            JwtAuthService = _jwtUserAuthService;
            userManager = _userManager;
            signInManager = _signInManager;
        }



        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(Customer model)
        {
            var applicationUser = new Customer()
            {

                Email = model.Email,
                FullName = model.FullName
            };
            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return (result);

            }
            catch (Exception ex)
            { throw ex; 
            }
        }







      [HttpPost]
        [Route("EmployeeAuth")]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employees), StatusCodes.Status400BadRequest)]
        public IActionResult Autnenticate([FromBody] Employees _Emp)
        {
            var token = JwtAuthService.Authenticate(_Emp);
            if (token == null)

                return Unauthorized();
            else
                return Ok(token);



        }

        [HttpPost]
        [Route("CustomerAuth")]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        public IActionResult AutnenticateCustomer([FromBody] Customer _customer)
        {
            var token = JwtAuthService.AuthenticateCus(_customer);
            if (token == null)

                return Unauthorized();
            else
                return Ok(token);



        }

        [HttpPost]
        [Route("DoctorAuth")]
        [ProducesResponseType(typeof(Doctor), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Doctor), StatusCodes.Status400BadRequest)]
        public IActionResult AutnenticateDoctor([FromBody] Doctor _doctor)
        {
            var token = JwtAuthService.AuthenticateDr(_doctor);
            if (token == null)

                return Unauthorized();
            else
                return Ok(token);

        }
*/
    }
}
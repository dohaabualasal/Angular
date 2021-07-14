using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KeepAPets.Infra.Services
{
   public  class JwtAuthServices//: IJwtAuthServices
    {
/*        private readonly IJwtAuthRepository JwtAuthRepository;
        public JwtAuthServices(IJwtAuthRepository jwtAuthRepository)
        {
            JwtAuthRepository = jwtAuthRepository;
        }

        public string Authenticate(Employees Emp)
        {
            if (AuthenticateEmployee(Emp) == 1)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, Emp.Email),
                new Claim(ClaimTypes.Hash, Emp.Password)
                //new Claim(ClaimTypes.pa, user.RoleID.ToString())
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                //user.Password = null;
                return tokenHandler.WriteToken(token);
            }
            return "Login Failed";
        }
        //CUSTOMER
        public string AuthenticateCus(Customer customer)
        {
            if (AuthenticateCustomer(customer) == 1)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, customer.Email),
                new Claim(ClaimTypes.Hash, customer.Password)

                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }
            return "Login Failed";
        }

        //DOCTOR
        public string AuthenticateDr(Doctor doctor)
        {
            if (AuthenticateDoctor(doctor) == 1)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, doctor.Email),
                new Claim(ClaimTypes.Hash, doctor.Password)

                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                //user.Password = null;
                return tokenHandler.WriteToken(token);
            }
            return "Login Failed";
        }

        public int AuthenticateEmployee(Employees Emp)
        {
            return JwtAuthRepository.AuthenticateEmployee(Emp);

        }

        public int AuthenticateCustomer(Customer customer)
        {
            return JwtAuthRepository.AuthenticateCustomer(customer);

        }

        public int AuthenticateDoctor(Doctor doctor)
        {
            return JwtAuthRepository.AuthenticateDoctor(doctor);

        }*/
    }
}

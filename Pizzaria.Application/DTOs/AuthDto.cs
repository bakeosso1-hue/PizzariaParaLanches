using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Application.DTOs
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IList <string> Roles { get; set; } = new List<string>();
    }
}

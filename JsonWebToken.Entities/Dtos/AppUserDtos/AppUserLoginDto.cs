using JsonWebToken.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Entities.Dtos.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

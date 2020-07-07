using JsonWebToken.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}

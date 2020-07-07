using JsonWebToken.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Entities.Token
{
    public class JwtAccessToken : IToken
    {
        public string Token { get; set; }
    }
}

using Microsoft.IdentityModel.Tokens;
using shared;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace net461console
{
    class Program
    {
        static void Main(string[] args)
        {
            var jwtSecurityToken = new JwtSecurityToken(Resources.Jwt);

            var jsonWebKeySet = new JsonWebKeySet(Resources.Jwks.Trim());

            var securityKeys = BuldSecurityKeys(jsonWebKeySet);

            var valid = IsValid(jwtSecurityToken, securityKeys);
        }

        private static List<SecurityKey> BuldSecurityKeys(JsonWebKeySet jsonWebKeySet)
        {
            var keys = new List<SecurityKey>();
            foreach (var webKey in jsonWebKeySet.Keys)
            {
                var e = Base64UrlEncoder.DecodeBytes(webKey.E);
                var n = Base64UrlEncoder.DecodeBytes(webKey.N);

                var key = new RsaSecurityKey(new RSAParameters { Exponent = e, Modulus = n })
                {
                    KeyId = webKey.Kid
                };

                keys.Add(key);
            }

            return keys;
        }

        public static bool IsValid(JwtSecurityToken token, List<SecurityKey> keys, string nameClaimType = null)
        {
            ClaimsPrincipal claimsPrincipal = null;

            var parameters = new TokenValidationParameters()
            {
                ValidAudiences = token.Audiences,
                IssuerSigningKeys = keys,
                NameClaimType = nameClaimType ?? JwtRegisteredClaimNames.Sub,
                ValidIssuers = new[] { token.Issuer }
            };

            bool isValid = false;

            try
            {
                string jwt = token.RawData;
                SecurityToken securityToken = null;
                claimsPrincipal = new JwtSecurityTokenHandler().ValidateToken(jwt, parameters, out securityToken);
                isValid = claimsPrincipal.Identity.IsAuthenticated;
            }
            catch (SecurityTokenExpiredException)
            {
            }
            catch (SecurityTokenInvalidSignatureException)
            {
            }

            return isValid;
        }
    }
}

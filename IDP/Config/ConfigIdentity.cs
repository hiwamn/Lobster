using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IDP.Configs
{
    public class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "486F37CA-1C29-4F23-B878-D05A142B6C0B",
                    Username = "hiwa",
                    Password = "123456",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Alireza"),
                        new Claim("family_name", "Oroumand"),
                        new Claim("address", "khoonamoon"),
                        new Claim("role", "role1"),
                    }
                },
                new TestUser
                {
                    SubjectId = "F8CEAE1A-5582-4673-9B8C-CB6C41C7C01E",
                    Username ="Hossein",
                    Password = "1qaz!QAZ"
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),

            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
            new Client
                {
                    ClientName = "angular_spa",
                    ClientId = "angular_spa",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RedirectUris = new List<string>
                    {
                        //"https://192.168.30.153:4200/signin-oidc"
                        "http://192.168.30.153:4200/auth-callback"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        //"https://192.168.30.153:4200/signout-callback-oidc"
                        "http://192.168.30.153:4200"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        //IdentityServerConstants.StandardScopes.Address,
                        //"roles",
                        //"MYAPI"
                    },
                    AllowedCorsOrigins = {"http://192.168.30.153:4200"}
                ,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }
                }
            };
        }
     
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>
            {
                new ApiResource(
                    name: "MYAPI",
                    displayName: "My API",
                    claimTypes: new List<string> {"role" })
            };
        }
    }
}

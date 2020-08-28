// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("demo.api", "IDS Demo API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client {
                    ClientId = "demo.client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("secretAF".Sha256())
                    },

                    AllowedScopes = { "demo.api" }
                }
            };
    }
}
// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Mcpelee.Owin.Security.Amazon
{
    internal static class Constants
    {
        public const string DefaultAuthenticationType = "Amazon";

        internal const string AuthorizationEndpoint = "https://www.amazon.com/ap/oa";
        internal const string TokenEndpoint = "https://api.amazon.com/auth/O2/token";
        internal const string UserInformationEndpoint = "https://api.amazon.com/user/profile";
    }
}

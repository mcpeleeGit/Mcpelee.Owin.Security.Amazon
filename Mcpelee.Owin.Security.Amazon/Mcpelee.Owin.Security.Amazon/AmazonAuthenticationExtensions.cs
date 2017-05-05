// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin.Security;
using Mcpelee.Owin.Security.Amazon;

namespace Owin
{
    /// <summary>
    /// Extension methods for using <see cref="AmazonAuthenticationMiddleware"/>
    /// </summary>
    public static class AmazonAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Amazon
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="options">Middleware configuration options</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseAmazonAuthentication(this IAppBuilder app, AmazonAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(AmazonAuthenticationMiddleware), app, options);
            return app;
        }

        /// <summary>
        /// Authenticate users using Amazon
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="appId">The appId assigned by Amazon</param>
        /// <param name="appSecret">The appSecret assigned by Amazon</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseAmazonAuthentication(
            this IAppBuilder app,
            string appId,
            string appSecret)
        {
            return UseAmazonAuthentication(
                app,
                new AmazonAuthenticationOptions
                {
                    AppId = appId,
                    AppSecret = appSecret,
                });
        }
    }
}

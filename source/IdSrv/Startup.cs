/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using IdentityManager.Core.Logging;
using IdentityManager.Logging;
using IdSrv;
using IdSrv.IdSvr;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(StartupWithLocalhostSecurity))]
[assembly: OwinStartup(typeof(StartupWithHostCookiesSecurity))]

namespace IdSrv
{
    public class StartupWithHostCookiesSecurity
    {
        public void Configuration(IAppBuilder app)
        {
            LogProvider.SetCurrentLogProvider(new TraceSourceLogProvider());
            
            // this configures an embedded IdentityServer to act as an external authentication provider
            // when using IdentityManager in Token security mode. normally you'd configure this elsewhere.
            app.Map("/ids", ids =>
            {
                IdSvrConfig.Configure(ids);
            });
        }
    }

}

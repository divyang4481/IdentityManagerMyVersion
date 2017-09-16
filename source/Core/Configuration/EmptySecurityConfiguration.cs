using Owin;
using Microsoft.Owin;

namespace IdentityManager.Configuration
{
    public class EmptySecurityConfiguration : SecurityConfiguration
    {
        public override void Configure(IAppBuilder app)
        {
            //Do nothing
        }

        internal override void SignOut(IOwinContext context)
        {
            //Do nothing
        }
    }
}

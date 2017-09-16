using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManager.Configuration
{
    public class OAuthSettings
    {
        public string authorization_endpoint { get; set; }
        public string client_id { get; set; }
        public string authority { get; set; }
        public string response_type { get; set; }
        public string redirect_uri { get; set; }
        public string scope { get; set; }
        public string acr_values { get; set; }
        public bool load_user_profile { get; set; }
    }
}

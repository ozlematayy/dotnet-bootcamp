using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; } = "dotnet_bootcamp_panel_key_value_here_secret";
        public int RefreshTokenTTL { get; set; }
    }
}

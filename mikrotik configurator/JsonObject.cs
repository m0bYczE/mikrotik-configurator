using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikrotik_configurator
{
    class JsonObject
    {
        public wifiSettings wifi { get; set; }
        public cableSettings cable { get; set; }
        public portSettings[] portforwards { get; set; }
    }

    class wifiSettings
    {
        public string ssid { get; set; }
        public string password { get; set; }
        public string ip { get; set; }
        public int subnetmask { get; set; }
        public string dnsserver { get; set; }

    }

    class cableSettings
    {
        public string ip { get; set; }
        public string subnetmask { get; set; }
    }

    class portSettings
    {
        public string fromIp { get; set; }
        public string toIp { get; set; }
        public int inPort { get; set; }
        public int outPort { get; set; }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikrotik_configurator
{
    class ConfigCreator
    {
        public ConfigCreator()
        {
        }

        public string createConfig(JsonObject json)
        {
            StringBuilder sstr = new StringBuilder();
            //create bridge
            sstr.AppendLine("/interface bridge");
            sstr.AppendLine("add name=bridge1");
            //bridge interfaces
            sstr.AppendLine("/interface ethernet");
            sstr.AppendLine("set [ find default-name=ether2 ] name=ether2-master");
            sstr.AppendLine("set [ find default-name=ether3 ] master-port=ether2-master");
            sstr.AppendLine("set [ find default-name=ether4 ] master-port=ether2-master");
            sstr.AppendLine("set [ find default-name=ether5 ] master-port=ether2-master");
            //neighbor info
            sstr.AppendLine("/ip neighbor discovery");
            sstr.AppendLine("set ether1 discover=no");
            //security profiles
            sstr.AppendLine("/interface wireless security-profiles");
            sstr.AppendLine("add authentication-types=wpa2-psk eap-methods=\"\" management-protection=allowed mode=dynamic-keys name=" +json.wifi.ssid +" supplicant-identity=\"\" wpa2-pre-shared-key=\"" + json.wifi.password +"\"");
            //wireless interface
            sstr.AppendLine("/interface wireless");
            sstr.AppendLine("set [ find default-name=wlan1 ] band=2ghz-b/g/n channel-width=20/40mhz-Ce disabled=no distance=indoors frequency=auto mode=station security-profile=Gumball ssid="+ json.wifi.ssid +" wireless-protocol=802.11");
            //bridge port
            sstr.AppendLine("/interface bridge port");
            sstr.AppendLine("add bridge=bridge1 comment=defconf interface=ether2-master");
            sstr.AppendLine("add bridge=bridge1 comment=defconf disabled=yes interface=wlan1");
            sstr.AppendLine("add bridge=bridge1 interface=ether1");
            //ip configs
            sstr.AppendLine("/ip address");
            string[] parts = json.cable.ip.Split('.'); 
            uint ipnum = (Convert.ToUInt32(parts[0]) << 24) |
                         (Convert.ToUInt32(parts[1]) << 16) |
                         (Convert.ToUInt32(parts[2]) << 8) |
                         Convert.ToUInt32(parts[3]);

            int maskbits = Convert.ToInt32(json.cable.subnetmask);
            uint mask = 0xffffffff;
            mask <<= (32 - maskbits);
            uint ipstart = ipnum & mask;
            //uint ipend = ipnum | (mask ^ 0xffffffff);
            sstr.AppendLine("add address = "+ json.wifi.ip +" interface=wlan1");
            sstr.AppendLine("add address= " +json.cable.ip +"/"+ json.cable.subnetmask+ " comment=defconf interface=ether2-master network=192.168.88.0");
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();
            sstr.AppendLine();

        }
    }
}

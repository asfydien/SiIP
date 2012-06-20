using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace SiIP
{
    class TCPIPviaRegistry
    {
        public static void SetIP(string KeyGUID, string IpAddresses, string SubnetMask, string Gateway, string DnsSearchOrder)
        {
            // Registry key where IP information is stored.
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", true);
            
            foreach (string s in key.GetSubKeyNames())
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + s, true);

                // In general, active network card will have more than 12 setting values
                if (rk.Name.Contains(KeyGUID))   
                {
                    try
                    {
                        if (IpAddresses.Trim() != "")
                        {
                            string[] sIP = IpAddresses.Split(',');
                            string[] sGateway = Gateway.Split(',');

                            rk.SetValue("IPAddress", sIP);
                            rk.SetValue("DhcpSubnetMask", SubnetMask);
                            rk.SetValue("DefaultGateway", sGateway);
                        }

                        rk.SetValue("NameServer", DnsSearchOrder);
                        rk.SetValue("EnableDHCP", 1, RegistryValueKind.DWord);
                    }
                    catch
                    {
                        // Error message logic here.
                    }

                }
                rk.Close();
            }
            
        }
    }
}

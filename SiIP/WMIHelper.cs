/*
    This class base on "WMIHelper.cs" part of "SwitchNetConfig" by Omar Al Zabir 
    Modified by Sofyan <http://unyukid.web.id/>
*/

using System;
using System.Collections;
using System.Management;

namespace SiIP
{
    /// <summary>
    /// A Helper class which provides convenient methods to set/get network
    /// configuration
    /// </summary>
    public class WMIHelper
    {
        #region Public Static

        /// <summary>
        /// Enable DHCP on the NIC
        /// </summary>
        /// <param name="nicName">Name of the NIC</param>
        public static void SetDHCP(string nicName)
        {
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (ManagementObjectCollection moc = mc.GetInstances())
                {

                    foreach (ManagementObject mo in moc)
                    {
                        // Make sure this is a IP enabled device. Not something like memory card or VM Ware
                        if ((bool)mo["IPEnabled"])
                            if (mo["Caption"].Equals(nicName))
                            {
                                ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");
                                newDNS["DNSServerSearchOrder"] = null;
                                ManagementBaseObject enableDHCP = mo.InvokeMethod("EnableDHCP", null, null);
                                ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                            }
                    }
                }
            }
        }

        /// <summary>
        /// Set IP for the specified network card name
        /// </summary>
        /// <param name="nicName">Caption of the network card</param>
        /// <param name="IpAddresses">Comma delimited string containing one or more IP</param>
        /// <param name="SubnetMask">Subnet mask</param>
        /// <param name="Gateway">Gateway IP</param>
        /// <param name="DnsSearchOrder">Comma delimited DNS IP</param>
        //[PrincipalPermissionAttribute(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        public static void SetIP(string nicName, string IpAddresses, string SubnetMask, string Gateway, string DnsSearchOrder)
        {
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (ManagementObjectCollection moc = mc.GetInstances())
                {

                    foreach (ManagementObject mo in moc)
                    {
                        // Make sure this is a IP enabled device. Not something like memory card or VM Ware
                        //if ((bool)mo["IPEnabled"])
                        if (mo["Caption"].Equals(nicName))
                        {

                            ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");
                            ManagementBaseObject newGate = mo.GetMethodParameters("SetGateways");
                            ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");

                            newGate["DefaultIPGateway"] = new string[] { Gateway };
                            newGate["GatewayCostMetric"] = new int[] { 1 };

                            newIP["IPAddress"] = IpAddresses.Split(',');
                            newIP["SubnetMask"] = new string[] { SubnetMask };

                            newDNS["DNSServerSearchOrder"] = DnsSearchOrder.Split(',');

                            ManagementBaseObject setIP = mo.InvokeMethod("EnableStatic", newIP, null);
                            ManagementBaseObject setGateways = mo.InvokeMethod("SetGateways", newGate, null);
                            ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns the network card configuration of the specified NIC
        /// </summary>
        /// <param name="nicName">Name of the NIC</param>
        /// <param name="ipAdresses">Array of IP</param>
        /// <param name="subnets">Array of subnet masks</param>
        /// <param name="gateways">Array of gateways</param>
        /// <param name="dnses">Array of DNS IP</param>
        public static void GetIP(string nicName, out string[] ipAdresses, out string[] subnets, out string[] gateways, out string[] dnses)
        {
            ipAdresses = null;
            subnets = null;
            gateways = null;
            dnses = null;

            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (ManagementObjectCollection moc = mc.GetInstances())
                {

                    foreach (ManagementObject mo in moc)
                    {
                        // Make sure this is a IP enabled device. Not something like memory card or VM Ware
                        if ((bool)mo["ipEnabled"])
                            if (mo["Caption"].Equals(nicName))
                            {
                                ipAdresses = (string[])mo["IPAddress"];
                                subnets = (string[])mo["IPSubnet"];
                                gateways = (string[])mo["DefaultIPGateway"];
                                dnses = (string[])mo["DNSServerSearchOrder"];

                                break;
                            }
                    }
                }
            }
        }

        public struct infoNIC
        {
            private string m_Caption, m_Name, m_GUID;
            private int m_NetConnectionStatus, m_AdapterTypeId;

            public string Caption
            {
                get { return m_Caption; }
                set { m_Caption = value; }
            }
            public string Name
            {
                get { return m_Name; }
                set { m_Name = value; }
            }
            public int NetConnectionStatus
            {
                get { return m_NetConnectionStatus; }
                set { m_NetConnectionStatus = value; }
            }
            public int AdapterTypeId
            {
                get { return m_AdapterTypeId; }
                set { m_AdapterTypeId = value; }
            }
            public string GUID
            {
                get { return m_GUID; }
                set { m_GUID = value; }
            }
        }

        /// <summary>
        /// Returns the list of Network Interfaces installed
        /// </summary>
        /// <returns>Array list of string</returns>
        public static infoNIC[] GetNICNames()
        {
            infoNIC[] nicNames = new infoNIC[0];

            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapter"))
            {
                using (ManagementObjectCollection moc = mc.GetInstances())
                {

                    int idx = 0;
                    foreach (ManagementObject mo in moc)
                        if (Convert.ToString(mo["NetConnectionStatus"]) != "")
                        {
                            idx++;
                            Array.Resize(ref nicNames, idx);

                            nicNames[idx - 1].Caption = (string)mo["Caption"];
                            nicNames[idx - 1].Name = (string)mo["Name"];
                            nicNames[idx - 1].NetConnectionStatus = Convert.ToInt32(mo["NetConnectionStatus"]);

                            nicNames[idx - 1].AdapterTypeId = Convert.ToInt32(mo["AdapterTypeId"]); // win7

                            try // win7
                            {
                                nicNames[idx - 1].GUID = (string)mo["GUID"];
                            }
                            catch
                            {
                                nicNames[idx - 1].GUID = "";
                            }

                        }
                }
            }
            return nicNames;
        }

        #endregion
    }
}

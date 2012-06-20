using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SiIP
{
    class Config
    {
        public Config() { }

        public struct Profile
        {
            string m_Name, m_IP, m_Subnet, m_Gateway, m_DNS;
            bool m_UseDHCP, m_UseProxy;

            public string Name
            {
                get { return m_Name; }
                set { m_Name = value; }
            }
            public string IP
            {
                get { return getValue(m_IP); }
                set { m_IP = value; }
            }
            public string Subnet
            {
                get { return getValue(m_Subnet); }
                set { m_Subnet = value; }
            }
            public string Gateway
            {
                get { return getValue(m_Gateway); }
                set { m_Gateway = value; }
            }
            public string DNS
            {
                get { return getValue(m_DNS); }
                set { m_DNS = value; }
            }
            public bool UseDHCP
            {
                get { return m_UseDHCP; }
                set { m_UseDHCP = value; }
            }
            public bool UseProxy
            {
                get { return m_UseProxy; }
                set { m_UseProxy = value; }
            }

            private string getValue(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return string.Empty;
                else
                    return str;
            }
        }

        public Profile[] getProfiles(string fileName)
        {
            ArrayList arProfil = new ArrayList();

            XmlReader reader = XmlReader.Create(fileName);

            while (reader.ReadToFollowing("Profil"))
            {
                Profile prof = new Profile();

                reader.ReadToFollowing("Name");
                prof.Name = reader.ReadElementContentAsString();

                reader.ReadToFollowing("IP");
                prof.IP = reader.ReadElementContentAsString();

                reader.ReadToFollowing("Subnet");
                prof.Subnet = reader.ReadElementContentAsString();

                reader.ReadToFollowing("Gateway");
                prof.Gateway = reader.ReadElementContentAsString();

                reader.ReadToFollowing("DNS");
                prof.DNS = reader.ReadElementContentAsString();

                reader.ReadToFollowing("UseDHCP");
                prof.UseDHCP = reader.ReadElementContentAsBoolean();

                reader.ReadToFollowing("UseProxy");
                prof.UseProxy = reader.ReadElementContentAsBoolean();

                arProfil.Add(prof);
            }

            Profile[] ret =  new Profile[arProfil.Count];

            for (int i = 0; i < arProfil.Count; i++)
                ret[i] = (Profile)arProfil[i];
            
            arProfil.Clear();
            
            return ret;
        }
    }
}

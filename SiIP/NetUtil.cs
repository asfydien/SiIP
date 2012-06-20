using System;
using System.Net;
using System.Runtime.InteropServices;

namespace SiIP
{
    /// <summary>
    /// Common network functions.
    /// </summary>
    public class NetUtil
    {
        #region Enum
        [Flags]
        public enum InternetConnectionStatesType : int
        {
            ModemConnection = 0x1,
            LANConnection = 0x2,
            ProxyConnection = 0x4,
            RASInstalled = 0x10,
            Offline = 0x20,
            ConnectionConfigured = 0x40
        }

        #endregion

        #region Interop Definitions

        [DllImport("WININET", CharSet = CharSet.Auto)]
        private static extern bool InternetGetConnectedState(
            ref InternetConnectionStatesType lpdwFlags,
            int dwReserved);

        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache();

        #endregion

        #region Connection State Functions

        public static InternetConnectionStatesType CurrentState
        {
            get
            {
                InternetConnectionStatesType state = 0;

                InternetGetConnectedState(ref state, 0);

                return state;
            }
        }

        public static bool IsOnline()
        {
            InternetConnectionStatesType connectionStatus = CurrentState;

            return (!IsFlagged((int)InternetConnectionStatesType.Offline, (int)connectionStatus));
        }

        #endregion

        #region Other Network Functions

        public static IPHostEntry ResolveHost(string hostname)
        {
            try
            {
                return Dns.GetHostByName(hostname);
            }
            catch {}

            return null;
        }

        public static UInt32 FlushDNSCache()
        {
            return DnsFlushResolverCache();
        }

        #endregion

        public static bool IsFlagged(int flaggedEnum, int flaggedValue)
        {
            if ((flaggedEnum & flaggedValue) != 0)
                return true;
            else
                return false;
        }
    }
}

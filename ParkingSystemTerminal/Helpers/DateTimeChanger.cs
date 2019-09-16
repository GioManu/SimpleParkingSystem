using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace ParkingSystemTerminal.Helpers {
    class DateTimeChanger {

        [DllImport("kernel32.dll")]
        public extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME {
            public short Year;
            public short Month;
            public short DayOfWeek;
            public short Day;
            public short Hour;
            public short Minute;
            public short Second;
            public short Milliseconds;
        };

        ///<summary>
        /// Changes System Date and Time
        ///</summary>
        public static void ChangeDateTime(DateTime date)
        {
            date = date.ToUniversalTime();

            SYSTEMTIME time = new SYSTEMTIME()
            {
                Year = (Int16)date.Year,
                Month = (Int16)date.Month,
                DayOfWeek = (Int16)date.DayOfWeek,
                Day = (Int16)date.Day,
                Hour = (Int16)date.Hour,
                Minute = (Int16)date.Minute,
                Second = (Int16)date.Second,
                Milliseconds = (Int16)date.Millisecond
            };

            SetSystemTime(ref time);
        }
        ///<summary>
        /// Returns Internet Time From Target Host If Internet Connection Is Available
        ///</summary>
        public static DateTime GetNetworkTime()
        {
            const string ntpServer = "pool.ntp.org";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B; //LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)
            DateTime networkDateTime = DateTime.Now;
            String timeZone = TimeZone.CurrentTimeZone.StandardName;

            try
            {
                var addresses = Dns.GetHostEntry(ntpServer).AddressList;
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                ulong intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
                ulong fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
                DateTime tmp = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);
                networkDateTime = TimeZoneInfo.ConvertTimeFromUtc(tmp, TimeZoneInfo.FindSystemTimeZoneById(timeZone));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            return networkDateTime;
        }

        /// <summary>
        /// Comparing And Changing Local DateTime To Server DateTime
        /// </summary>
        public static void CheckDateTime()
        {
            DateTime dt = GetNetworkTime();
            if (dt.ToString("d/m/yy HH:mm") != DateTime.Now.ToString("d/m/yy HH:mm"))
            {
                Console.WriteLine("Wrong Date");
                ChangeDateTime(dt);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtilties
{
    public class IPScanner
    {
        static int upCount = 0;
        static object lockObj = new object();

        public static IEnumerable<UnicastIPAddressInformation> GetDefaultGateway()
        {
            NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface Interface in Interfaces)
            {
                if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                Console.WriteLine(Interface.Description);
                UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                
                foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                {
                    //Console.WriteLine("\tIP Address is {0}", UnicatIPInfo.Address);
                    //Console.WriteLine("\tSubnet Mask is {0}", UnicatIPInfo.IPv4Mask);
                    yield return UnicatIPInfo;
                }
            }
        }

        public static IEnumerable<string> ScanIPs()
        {

            string hostName = Dns.GetHostName();

            string myIP = "192.168.1.11";

            var bytes = IPAddress.Parse(myIP).GetAddressBytes();
            bytes[3] = 0;
            var IPaddress1 = IPAddress.Parse(myIP).GetAddressBytes()[0].ToString() + "." + IPAddress.Parse(myIP).GetAddressBytes()[1].ToString() + "." + IPAddress.Parse(myIP).GetAddressBytes()[2].ToString() + ".";
            
            for (int i = 1; i < 255; i++)
            {
                string ip = IPaddress1 + i.ToString();

                Ping p = new Ping();
                var reply = p.Send(ip, 100);
                if (reply.Status == IPStatus.Success)
                {
                    yield return ip;
                }
                //p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                //countdown.AddCount();
                //p.SendAsync(ip, 100, ip); break;

            }

        }

        public static IEnumerable<string> ScanIPsAsync()
        {
            throw new NotImplementedException();
        }

        /*
        static void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                //Console.WriteLine("{0}", ip);
                //txtConsole.AppendText(String.Format(@"{0}", ip + System.Environment.NewLine));


                //Computers.Add(Addr.ip);
                //Assessment.Assessment.checkedListBox1.Items.Add(String.Format(@"{0}", ip));
                //Computer ip = new Computer("{0}",ip,"ports","service");
                lock (lockObj)
                {
                    upCount++;
                }

                if (!Computers.ContainsKey(ip))
                {
                    Computers.Add(ip, null);
                }



            }
            else if (e.Reply == null)
            {
            }

        }
        */
    }
}

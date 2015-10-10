using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment;
using System.Net;
using System.Net.NetworkInformation;
using Computers;



namespace PingSweep
{
    public class PingSweep
    {



        static int upCount = 0;
        static object lockObj = new object();


        public static IPAddress GetDefaultGateway()
        {
            //var card = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();
            /*
            Console.WriteLine("Gateways");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                if(addresses.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach(GatewayIPAddressInformation address in addresses)
                    {
                        Console.WriteLine("  Gateway Address ...........: {0}", address.Address.ToString());
                    }
                    Console.WriteLine();
                    
                }
            
            }

            return null;*/

            NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface Interface in Interfaces)
            {
                if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                Console.WriteLine(Interface.Description);
                UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                {
                    Console.WriteLine("\tIP Address is {0}", UnicatIPInfo.Address);
                    Console.WriteLine("\tSubnet Mask is {0}", UnicatIPInfo.IPv4Mask);
                }
            }
            return null;

            /* foreach (var blah in IPGlobalProperties.GetIPGlobalProperties().GetUnicastAddresses())
             {
                 if (blah.Address.AddressFamily == AddressFamily.InterNetwork)
                 {

                     return blah.Address;
                 }

             }


             return null;
             //if (card == null) return null;
             //var address = card.GetIPProperties();
             //return address;*/
        }

        


        public static void PingSweeper()
        {

            string hostName = Dns.GetHostName();

            string myIP = "192.168.1.11";





            var bytes = IPAddress.Parse(myIP).GetAddressBytes();
            bytes[3] = 0;
            //  IPAddress ipAddress = new IPAddress(bytes);
            var IPaddress1 = IPAddress.Parse(myIP).GetAddressBytes()[0].ToString() + "." + IPAddress.Parse(myIP).GetAddressBytes()[1].ToString() + "." + IPAddress.Parse(myIP).GetAddressBytes()[2].ToString() + ".";
            //txtConsole.AppendText(String.Format(@"{0}", IPaddress1 + System.Environment.NewLine));

            //string ipBase = "10.0.0.";
            for (int i = 1; i < 255; i++)
            {
                string ip = IPaddress1 + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                //countdown.AddCount();
                p.SendAsync(ip, 100, ip); break;

            }


            //Assessment.Assessment.txtConsole.AppendText(String.Format(@"Hostname: {0}", hostName + System.Environment.NewLine));
            //Assessment.Assessment.txtConsole.AppendText(String.Format(@"IP Address: {0}", myIP + System.Environment.NewLine));
            //Assessment.Assessment.txtConsole.AppendText(String.Format(@"Network: {0}.{1}.{2}", bytes[0], bytes[1], bytes[2] + System.Environment.NewLine + System.Environment.NewLine));
            //Assessment.Assessment.txtConsole.AppendText(String.Format(@"Note: Currently this will only work with a /24 network" + System.Environment.NewLine));

            // foreach (Computer e in listPC)
            // {

            //}
            //txtConsole.AppendText(String.Format(@"{0}", Computer.ip + System.Environment.NewLine));

        }


        static void  p_PingCompleted(object sender, PingCompletedEventArgs e)
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


    }
}

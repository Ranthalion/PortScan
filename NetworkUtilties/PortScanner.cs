using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtilties
{
    public class PortScanner
    {

        public static IEnumerable<int> Scan(string ip, int startPort, int endPort)
        {
            List<int> openPorts = new List<int>();

            for (int port = startPort; port <= endPort; port++)
            {
                Debug.WriteLine(string.Format("Scanning port {0}", port));
                Socket scanSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
         
                try
                {
                    scanSocket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
                    scanSocket.Disconnect(false);
                    openPorts.Add(port);
                    //scanSocket.BeginConnect(new IPEndPoint(ip, port), ScanCallBack, new ArrayList() { scanSocket, port });

                }
                catch(Exception ex)
                {
                    //bury exception since it means we could not connect to the port
                }

            }

            return openPorts;
        }

        /// <summary>  
        /// BeginConnect  
        /// </summary>  
        /// <param name="result">Connect</param>  
        ///         
        public void ScanCallBack(IAsyncResult result)
        {
            //    
            List<int> ports = new List<int>();



            ArrayList arrList = (ArrayList)result.AsyncState;
            Socket scanSocket = (Socket)arrList[0];
            int port = (int)arrList[1];
            //  
            if (result.IsCompleted && scanSocket.Connected)
            {
                Console.WriteLine("{0,5}\t", port);
                ports.Add(port);


               

            }            

            scanSocket.Close();
            
        }
    }
}

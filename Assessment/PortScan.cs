using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Collections;

namespace PortScan
{
    class PortScan
    {


        public void Scan(string[] args)
        {
            IPAddress ip;
            int startPort, endPort;
            if (GetPortRange(args, out ip, out startPort, out endPort) == true)  //  
            {
                Scan(ip, startPort, endPort);   //  

                //Console.ReadKey();
                //txtConsole.AppendText(string.Format("{0}", ip + System.Environment.NewLine));
            }
        }




        private bool GetPortRange(string[] args, out IPAddress ip, out int startPort, out int endPort)
        {
            ip = null;
            startPort = endPort = 0;
            //   

            if (args.Length == 3)
            {
                //  
                if (IPAddress.TryParse(args[0], out ip) && int.TryParse(args[1], out startPort) && int.TryParse(args[2], out endPort))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("?");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("?");
                return false;
            }
            //Spin up and external executable...
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            
        }




        public void Scan(IPAddress ip, int startPort, int endPort)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine("{0}", ip);



            //            AppendText(ip);

            //            AppendText(String.Format(@"{0}",ip.Address, false);
            for (int port = startPort; port < endPort; port++)
            {
                Socket scanSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                //  
                do
                {
                    try
                    {
                        scanSocket.Bind(new IPEndPoint(IPAddress.Any, rand.Next(65535)));
                        break;
                    }
                    catch
                    {
                        //  
                    }
                } while (true);

                try
                {
                    scanSocket.BeginConnect(new IPEndPoint(ip, port), ScanCallBack, new ArrayList() { scanSocket, port });

                }
                catch
                {
                    // Console.WriteLine("port {0,5}\tClosed.\n{1}", port, ex.Message);  
                    continue;
                }

            }

            // Console.WriteLine("Port Scan Completed!");
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
                //txtConsole.AppendText(String.Format(@"{0,5}\t", port ));



                //ArrayList ports = new ArrayList();
                ports.Add(port);


                foreach (int i in ports)
                {
                    //AppendText(String.Format(@"{0}", i.ToString() + Environment.NewLine));


                }


            }
            else
            {
                //Console.WriteLine("port {0,5}\tClosed.", port);   
            }
            // 

            scanSocket.Close();
            // return pList;
        }

        /*delegate void AppendTextCallback(string text);
        private void AppendText(string text)
        {
            if (this.txtConsole.InvokeRequired)
            {
                AppendTextCallback d = new AppendTextCallback(AppendText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtConsole.AppendText(text);
            }
        }*/

    }
}

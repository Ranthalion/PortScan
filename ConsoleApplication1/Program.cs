using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtilties;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipAddresses = IPScanner.ScanIPs();
            foreach(string ip in ipAddresses)
            {
                Console.WriteLine(string.Format("Responded with IP: {0}.", ip));
                //Scan ports
                var ports = PortScanner.Scan(ip, 0, 65000);
                foreach (var port in ports)
                {
                    Console.WriteLine(string.Format("Found open port: {0}", port.ToString()));
                    
                }
                
            }



            Console.WriteLine("Scan Complete.");
        }
    }
}

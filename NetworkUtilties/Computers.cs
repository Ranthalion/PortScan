using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Assessment
{

    public class Computer
    {
        public string IP { get; set; }
        public List<int> OpenPorts { get; set; }

        public Computer()
        {
            OpenPorts = new List<int>();
        }
    }

}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server.Helper
{
    public class ConnectHelper
    {
        public static string IpAdress { get; set; } = "10.2.27.1";
        public static int Port { get; set; } = 27001;
        public static Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace SNMPBrowser
{
    class ClientSNMP
    {
        public static string host = "localhost";
        public static string community = "public";

        SimpleSnmp snmp = new SimpleSnmp(host, community);

        

    }
}


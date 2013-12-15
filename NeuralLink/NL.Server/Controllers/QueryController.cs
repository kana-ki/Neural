﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using NL.Common;
using NL.Server.View;
using NL.Server.Controllers;

namespace NL.Server.Servers {
    internal class QueryController : IRemoteController {

        public QueryController() : base() {
            ActionDictionary.Add("HASH", CheckHashAction);
            RemoteActionDictionary.Add("HASH", CheckHashAction);
        }

        private void CheckHashAction(String[] parameters) {
            NLConsole.WriteLine("Executed Hash Check Action", ConsoleColor.White);
        }

        private void CheckHashAction(String[] parameters, TcpClient client) {
            IPEndPoint endPoint = client.Client.RemoteEndPoint as IPEndPoint;
            IPAddress ipaddress = endPoint.Address;
            String consoleNotice = String.Format("[{0}] Executed hash check action.", ipaddress);
            NLConsole.WriteLine(consoleNotice, ConsoleColor.Yellow);
            Byte[] response = Encoding.ASCII.GetBytes("EXECUTED HASH CHECK ACTION");
            client.GetStream().Write(response, 0, response.Length);  
        }

        protected override void DefaultAction(CommandPattern command, TcpClient client) {
            IPEndPoint endPoint = client.Client.RemoteEndPoint as IPEndPoint;
            IPAddress ipaddress = endPoint.Address;
            String consoleNotice = String.Format("[{0}] Transmitted an unrecognised command: {1}.", ipaddress, command.Original);
            NLConsole.WriteLine(consoleNotice, ConsoleColor.Red);
            Byte[] response = Encoding.ASCII.GetBytes("UNRECOGNISED ACTION");
            client.GetStream().Write(response, 0, response.Length);
        }

    }
}
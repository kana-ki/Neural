﻿using System;


namespace NL.Server.Configuration {
    internal static class ServerConfiguration {

        public static Uri Repository = new Uri("D:\\Documents\\test repo\\", UriKind.Absolute);
        public static Boolean BeepOnConnection = false;
        public static Boolean BeepOnDisconnection = false;

    }
}

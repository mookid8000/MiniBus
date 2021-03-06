﻿using MiniBus.Contracts;
using System.Collections.Generic;

namespace MiniBus.Tests.Fakes
{
    public sealed class FakeBusConfig : IBusConfig
    {
        public int MaxRetries { get; set; }
        public string ReadQueue { get; set; }
        public string ErrorQueue { get; set; }
        public List<string> WriteQueues { get; private set; }        
        public bool AutoCreateLocalQueues { get; set; }
        public bool InstallMsmq { get; set; }
        public bool EnlistInAmbientTransactions { get; set; }
        public bool JsonSerialization { get; set; }
        public bool AutoDistributeOnSend { get; set; }
    }
}

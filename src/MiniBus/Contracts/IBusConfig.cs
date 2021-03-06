﻿using System.Collections.Generic;

namespace MiniBus.Contracts
{
    public interface IBusConfig
    {
        int MaxRetries { get; set; }
        string ReadQueue { get; set; }
        string ErrorQueue { get; set; }
        List<string> WriteQueues { get; }
        bool AutoCreateLocalQueues { get; set; }
        bool InstallMsmq { get; set; }
        bool EnlistInAmbientTransactions { get; set; }
        bool JsonSerialization { get; set; }
        bool AutoDistributeOnSend { get; set; }
    }
}

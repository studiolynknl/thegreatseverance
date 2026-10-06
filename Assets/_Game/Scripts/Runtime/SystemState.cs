using System;
using System.Collections.Generic;

namespace TheGreatSeverance.Runtime
{
    [Serializable]
    public sealed class SystemState
    {
        public string systemDefinitionId;
        public string ownerFactionId;
        public long population;
        public int industry;
        public List<string> stationedFleetIds = new();
    }
}

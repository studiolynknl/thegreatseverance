using System;
using System.Collections.Generic;

namespace TheGreatSeverance.Runtime
{
    [Serializable]
    public sealed class FleetState
    {
        public string fleetId;
        public string displayName;
        public string factionId;
        public string currentSystemId;
        public List<ShipState> ships = new();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGreatSeverance.Runtime
{
    [Serializable]
    public sealed class CampaignState
    {
        public List<SystemState> systems = new();
        public List<FleetState> fleets = new();

        public SystemState GetSystem(string id) => systems.FirstOrDefault(x => x.systemDefinitionId == id);
        public FleetState GetFleet(string id) => fleets.FirstOrDefault(x => x.fleetId == id);
    }
}

using System.Linq;
using TheGreatSeverance.Runtime;

namespace TheGreatSeverance.Campaign
{
    public sealed class FleetMovementService
    {
        private readonly GalaxyGraph graph;
        private readonly CampaignState campaign;

        public FleetMovementService(GalaxyGraph graph, CampaignState campaign)
        {
            this.graph = graph;
            this.campaign = campaign;
        }

        public bool TryMove(string fleetId, string destinationSystemId, out BattleContext battle)
        {
            battle = null;
            var fleet = campaign.GetFleet(fleetId);
            if (fleet == null || !graph.AreConnected(fleet.currentSystemId, destinationSystemId))
                return false;

            var origin = campaign.GetSystem(fleet.currentSystemId);
            var destination = campaign.GetSystem(destinationSystemId);
            if (origin == null || destination == null) return false;

            origin.stationedFleetIds.Remove(fleet.fleetId);
            fleet.currentSystemId = destinationSystemId;
            destination.stationedFleetIds.Add(fleet.fleetId);

            var hostile = destination.stationedFleetIds
                .Select(campaign.GetFleet)
                .FirstOrDefault(other => other != null && other.fleetId != fleet.fleetId && other.factionId != fleet.factionId);

            if (hostile != null)
            {
                battle = new BattleContext { systemId = destinationSystemId, attacker = fleet, defender = hostile };
                BattleContextStore.Set(battle);
            }

            return true;
        }
    }
}

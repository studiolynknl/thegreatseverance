using TheGreatSeverance.Runtime;

namespace TheGreatSeverance.Campaign
{
    public static class CaptureVegaScenario
    {
        public const string Dominion = "dominion";
        public const string Sovereigns = "sovereigns";
        public const string Sol = "sol";
        public const string Vega = "vega";
        public const string Sirius = "sirius";
        public const string Carthage = "carthage";

        public static GalaxyGraph CreateGraph()
        {
            var graph = new GalaxyGraph();
            graph.AddConnection(Sol, Vega);
            graph.AddConnection(Vega, Sirius);
            graph.AddConnection(Vega, Carthage);
            return graph;
        }

        public static CampaignState CreateCampaign()
        {
            var state = new CampaignState();
            state.systems.Add(new SystemState { systemDefinitionId = Sol, ownerFactionId = Dominion, population = 18400000000, industry = 100 });
            state.systems.Add(new SystemState { systemDefinitionId = Vega, ownerFactionId = Sovereigns, population = 4200000000, industry = 60 });
            state.systems.Add(new SystemState { systemDefinitionId = Sirius, ownerFactionId = Sovereigns, population = 2100000000, industry = 45 });
            state.systems.Add(new SystemState { systemDefinitionId = Carthage, ownerFactionId = Sovereigns, population = 3100000000, industry = 55 });

            var dominionFleet = new FleetState { fleetId = "fleet_dominion_01", displayName = "1st Dominion Fleet", factionId = Dominion, currentSystemId = Sol };
            dominionFleet.ships.Add(NewShip("sentinel_01", "sentinel", "DCS Vigil"));
            dominionFleet.ships.Add(NewShip("sentinel_02", "sentinel", "DCS Watch"));
            dominionFleet.ships.Add(NewShip("lancer_01", "lancer", "DCS Spear"));
            dominionFleet.ships.Add(NewShip("bastion_01", "bastion", "DCS Resolute"));

            var vegaFleet = new FleetState { fleetId = "fleet_sovereign_vega", displayName = "Vega Defense Fleet", factionId = Sovereigns, currentSystemId = Vega };
            vegaFleet.ships.Add(NewShip("pathfinder_01", "pathfinder", "SV Wayfarer"));
            vegaFleet.ships.Add(NewShip("pathfinder_02", "pathfinder", "SV Relay"));
            vegaFleet.ships.Add(NewShip("pathfinder_03", "pathfinder", "SV Horizon"));
            vegaFleet.ships.Add(NewShip("hammer_01", "hammer", "SV Anvil"));

            state.fleets.Add(dominionFleet);
            state.fleets.Add(vegaFleet);
            state.GetSystem(Sol).stationedFleetIds.Add(dominionFleet.fleetId);
            state.GetSystem(Vega).stationedFleetIds.Add(vegaFleet.fleetId);
            return state;
        }

        private static ShipState NewShip(string id, string definitionId, string name) =>
            new ShipState { shipId = id, shipDefinitionId = definitionId, displayName = name, armor = 100f };
    }
}

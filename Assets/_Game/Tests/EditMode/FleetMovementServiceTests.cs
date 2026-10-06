using NUnit.Framework;
using TheGreatSeverance.Campaign;

namespace TheGreatSeverance.Tests
{
    public sealed class FleetMovementServiceTests
    {
        [Test]
        public void MovingDominionFleetIntoVega_CreatesBattleContext()
        {
            BattleContextStore.Clear();
            var campaign = CaptureVegaScenario.CreateCampaign();
            var service = new FleetMovementService(CaptureVegaScenario.CreateGraph(), campaign);

            var moved = service.TryMove("fleet_dominion_01", CaptureVegaScenario.Vega, out var battle);

            Assert.IsTrue(moved);
            Assert.IsNotNull(battle);
            Assert.AreEqual(CaptureVegaScenario.Vega, battle.systemId);
            Assert.AreEqual("fleet_dominion_01", battle.attacker.fleetId);
            Assert.AreEqual("fleet_sovereign_vega", battle.defender.fleetId);
        }
    }
}
